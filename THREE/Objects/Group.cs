﻿namespace IrisLib
{
    /// <summary>
    /// Class based on Object3D for grouping objects. Analogous to https://threejs.org/docs/index.html#api/objects/Group
    /// </summary>
    public class Group : Object3D
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Group()
        {
            Type = "Group";
        }
    }
}