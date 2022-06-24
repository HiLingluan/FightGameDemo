using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JMatrix.Editor
{
    [SerializeField]
    public class ResourceVersionInfo
    {
        public ResourceVersionInfo(string path, int length, int hashCode, int compressedLength, int compressedHashCode)
        {
            Path = path;
            Length = length;
            HashCode = hashCode;
            CompressedLength = compressedLength;
            CompressedHashCode = compressedHashCode;
        }

        public string Path
        {
            get;
            private set;
        }

        public int Length
        {
            get;
            private set;
        }

        public int HashCode
        {
            get;
            private set;
        }

        public int CompressedLength
        {
            get;
            private set;
        }

        public int CompressedHashCode
        {
            get;
            private set;
        }
    }
}
