﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MMD
{
    namespace Format
    {
        namespace PMD
        {
            public class FaceList : ChunkList<Face, uint> { }

            public class Face : Chunk
            {
                public ushort[] vertexIndices;
            }
        }
    }
}