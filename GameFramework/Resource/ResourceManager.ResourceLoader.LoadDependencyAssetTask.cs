//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

namespace GameFramework.Resource
{
    internal partial class ResourceManager
    {
        private partial class ResourceLoader
        {
            private sealed class LoadDependencyAssetTask : LoadResourceTaskBase
            {
                private readonly LoadResourceTaskBase m_MainTask;

                public LoadDependencyAssetTask(string assetName, int priority, ResourceInfo resourceInfo, string resourceChildName, string[] dependencyAssetNames, string[] scatteredDependencyAssetNames, LoadResourceTaskBase mainTask, object userData)
                    : base(assetName, null, priority, resourceInfo, resourceChildName, dependencyAssetNames, scatteredDependencyAssetNames, userData)
                {
                    m_MainTask = mainTask;
                    m_MainTask.TotalDependencyAssetCount++;
                }

                public override bool IsScene
                {
                    get
                    {
                        return false;
                    }
                }

                public override void OnLoadAssetSuccess(LoadResourceAgent agent, object asset, float duration)
                {
                    base.OnLoadAssetSuccess(agent, asset, duration);
                    m_MainTask.OnLoadDependencyAsset(agent, AssetName, asset, ResourceObject != null ? ResourceObject.Target : null);
                }

                public override void OnLoadAssetFailure(LoadResourceAgent agent, LoadResourceStatus status, string errorMessage)
                {
                    base.OnLoadAssetFailure(agent, status, errorMessage);
                    m_MainTask.OnLoadAssetFailure(agent, LoadResourceStatus.DependencyError, Utility.Text.Format("Can not load dependency asset '{0}', internal status '{1}', internal error message '{2}'.", AssetName, status.ToString(), errorMessage));
                }
            }
        }
    }
}
