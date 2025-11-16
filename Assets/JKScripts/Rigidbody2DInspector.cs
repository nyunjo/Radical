using UnityEditor;
using UnityEngine;

// This script replaces the Playground Rigidbody2D Inspector to prevent NullReferenceExceptions
[CustomEditor(typeof(Rigidbody2D))]
[CanEditMultipleObjects]
public class Rigidbody2DInspector : Editor
{
    SerializedProperty m_Mass;
    SerializedProperty m_LinearDrag;
    SerializedProperty m_AngularDrag;
    SerializedProperty m_GravityScale;
    SerializedProperty m_Interpolate;
    SerializedProperty m_CollisionDetection;
    SerializedProperty m_FreezeRotation;

    void OnEnable()
    {
        m_Mass = serializedObject.FindProperty("m_Mass");
        m_LinearDrag = serializedObject.FindProperty("m_LinearDrag");
        m_AngularDrag = serializedObject.FindProperty("m_AngularDrag");
        m_GravityScale = serializedObject.FindProperty("m_GravityScale");
        m_Interpolate = serializedObject.FindProperty("m_Interpolation");
        m_CollisionDetection = serializedObject.FindProperty("m_CollisionDetection");
        m_FreezeRotation = serializedObject.FindProperty("m_FreezeRotation");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        if (m_Mass != null)
            EditorGUILayout.PropertyField(m_Mass, new GUIContent("Mass"));

        if (m_LinearDrag != null)
            EditorGUILayout.PropertyField(m_LinearDrag, new GUIContent("Friction"));

        if (m_AngularDrag != null)
            EditorGUILayout.PropertyField(m_AngularDrag, new GUIContent("Angular Drag"));

        if (m_GravityScale != null)
            EditorGUILayout.PropertyField(m_GravityScale, new GUIContent("Gravity Scale"));

        if (m_Interpolate != null)
            EditorGUILayout.PropertyField(m_Interpolate, new GUIContent("Interpolate"));

        if (m_CollisionDetection != null)
            EditorGUILayout.PropertyField(m_CollisionDetection, new GUIContent("Collision Detection"));

        if (m_FreezeRotation != null)
            EditorGUILayout.PropertyField(m_FreezeRotation, new GUIContent("Freeze Rotation"));

        serializedObject.ApplyModifiedProperties();
    }
}
