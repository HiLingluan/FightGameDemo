//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace GameFramework.Resource
{
    internal partial class ResourceManager
    {
        private partial class ResourceLoader
        {
            private abstract class LoadResourceTaskBase : ITask
            {
                private static int s_Serial = 0;

                private readonly int m_SerialId;
                private readonly int m_Priority;
                private bool m_Done;
                private readonly string m_AssetName;
                private readonly Type m_AssetType;
                private readonly ResourceInfo m_ResourceInfo;
                private readonly string m_ResourceChildName;
                private readonly string[] m_DependencyAssetNames;
                private readonly string[] m_ScatteredDependencyAssetNames;
                private readonly object m_UserData;
                private readonly List<object> m_DependencyAssets;
                private readonly List<object> m_DependencyResources;
                private ResourceObject m_ResourceObject;
                private DateTime m_StartTime;
                private int m_TotalDependencyAssetCount;

                public LoadResourceTaskBase(string assetName, Type assetType, int priority, ResourceInfo resourceInfo, string resourceChildName, string[] dependencyAssetNames, string[] scatteredDependencyAssetNames, object userData)
                {
                    m_SerialId = s_Serial++;
                    m_Priority = priority;
                    m_Done = false;
                    m_AssetName = assetName;
                    m_AssetType = assetType;
                    m_ResourceInfo = resourceInfo;
                    m_ResourceChildName = resourceChildName;
                    m_DependencyAssetNames = dependencyAssetNames;
                    m_ScatteredDependencyAssetNames = scatteredDependencyAssetNames;
                    m_UserData = userData;
                    m_DependencyAssets = new List<object>();
                    m_DependencyResources = new List<object>();
                    m_ResourceObject = null;
                    m_StartTime = default(DateTime);
                    m_TotalDependencyAssetCount = 0;
                }

                public int SerialId
                {
                    get
                    {
                        return m_SerialId;
                    }
                }

                public int Priority
                {
                    get
                    {
                        return m_Priority;
                    }
                }

                public bool Done
                {
                    get
                    {
                        return m_Done;
                    }
                    set
                    {
                        m_Done = value;
                    }
                }

                public string AssetName
                {
                    get
                    {
                        return m_AssetName;
                    }
                }

                public Type AssetType
                {
                    get
                    {
                        return m_AssetType;
                    }
                }

                public ResourceInfo ResourceInfo
                {
                    get
                    {
                        return m_ResourceInfo;
                    }
                }

                public string ResourceChildName
                {
                    get
                    {
                        return m_ResourceChildName;
                    }
                }

                public ResourceObject ResourceObject
                {
                    get
                    {
                        return m_ResourceObject;
                    }
                }

                public abstract bool IsScene
                {
                    get;
                }

                public object UserData
                {
                    get
                    {
                        return m_UserData;
                    }
                }

                public DateTime StartTime
                {
                    get
                    {
                        return m_StartTime;
                    }
                    set
                    {
                        m_StartTime = value;
                    }
                }

                public int LoadedDependencyAssetCount
                {
                    get
                    {
                        return m_DependencyAssets.Count;
                    }
                }

                public int TotalDependencyAssetCount
                {
                    get
                    {
                        return m_TotalDependencyAssetCount;
                    }
                    set
                    {
                        m_TotalDependencyAssetCount = value;
                    }
                }

                public string[] GetDependencyAssetNames()
                {
                    return m_DependencyAssetNames;
                }

                public string[] GetScatteredDependencyAssetNames()
                {
                    return m_ScatteredDependencyAssetNames;
                }

                public object[] GetDependencyAssets()
                {
                    return m_DependencyAssets.ToArray();
                }

                public List<object> GetDependencyResources()
                {
                    return m_DependencyResources;
                }

                public void LoadMain(LoadResourceAgent agent, ResourceObject resourceObject)
                {
                    m_ResourceObject = resourceObject;
                    agent.Helper.LoadAsset(resourceObject.Target, ResourceChildName, AssetType, IsScene);
                }

                public virtual void OnLoadAssetSuccess(LoadResourceAgent agent, object asset, float duration)
                {

                }

                public virtual void OnLoadAssetFailure(LoadResourceAgent agent, LoadResourceStatus status, string errorMessage)
                {

                }

                public virtual void OnLoadAssetUpdate(LoadResourceAgent agent, LoadResourceProgress type, float progress)
                {

                }

                public virtual void OnLoadDependencyAsset(LoadResourceAgent agent, string dependencyAssetName, object dependencyAsset, object dependencyResource)
                {
                    m_DependencyAssets.Add(dependencyAsset);
                    if (dependencyResource != null && !m_DependencyResources.Contains(dependencyResource))
                    {
                        m_DependencyResources.Add(dependencyResource);
                    }
                }
            }
        }
    }
}
