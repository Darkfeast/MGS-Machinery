﻿/*************************************************************************
 *  Copyright © 2017-2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  FreeCrankEditor.cs
 *  Description  :  Custom editor for FreeCrank.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  2/26/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEditor;
using UnityEngine;

namespace Developer.Machinery
{
    [CustomEditor(typeof(FreeCrank), true)]
    [CanEditMultipleObjects]
    public class FreeCrankEditor : MechanismEditor
    {
        #region Property and Field
        protected FreeCrank Script { get { return target as FreeCrank; } }

        protected Vector3 Axis { get { return Script.transform.forward; } }

        protected Vector3 ZeroAxis
        {
            get
            {
                if (Application.isPlaying)
                {
                    var up = Quaternion.Euler(Script.StartAngles) * Vector3.up;
                    if (Script.transform.parent)
                        up = Script.transform.parent.rotation * up;
                    return up;
                }
                else
                    return Script.transform.up;
            }
        }
        #endregion

        #region Protected Method
        protected virtual void OnSceneGUI()
        {
            Handles.color = blue;
            DrawSphereCap(Script.transform.position, Quaternion.identity, nodeSize);
            DrawCircleCap(Script.transform.position, Script.transform.rotation, areaRadius);
            DrawArrow(Script.transform.position, Axis, arrowLength, nodeSize, blue, "Axis");
            DrawArrow(Script.transform.position, ZeroAxis, arrowLength, nodeSize, blue, "Zero");
            DrawArrow(Script.transform.position, Script.transform.up, areaRadius, nodeSize, blue, string.Empty);
            DrawArea();
            DrawRockers(Script.rockers, Script.transform, blue);
        }

        protected virtual void DrawArea()
        {
            Handles.color = transparentBlue;
            Handles.DrawSolidDisc(Script.transform.position, Axis, areaRadius);
        }
        #endregion
    }
}