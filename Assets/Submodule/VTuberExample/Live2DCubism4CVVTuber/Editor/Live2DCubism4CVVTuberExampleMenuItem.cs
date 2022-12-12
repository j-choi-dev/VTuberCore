using Live2D.Cubism.Core;
using Live2D.Cubism.Rendering;
using UnityEditor;
using UnityEngine;

namespace CVVTuber.Live2DCubism4
{
    public class Live2DCubism4CVVTuberExampleMenuItem : MonoBehaviour
    {

        [MenuItem("Tools/CVVTuberExample/Setup Live2DCubism4CVVTuberExample_Koharu", false, 1)]
        public static void SetLive2DCubism4CVVTuberSettings_Koharu()
        {
            GameObject koharu = GameObject.Find("Koharu");
            if (koharu != null)
            {

                bool allComplete = true;

                CubismModel live2DCubism4Model = koharu.GetComponent<CubismModel>();

                Animator animator = koharu.GetComponent<Animator>();


                CubismRenderController cubisumRenderController = koharu.GetComponent<CubismRenderController>();
                if (cubisumRenderController != null)
                {
                    Undo.RecordObject(cubisumRenderController, "Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                    cubisumRenderController.SortingMode = CubismSortingMode.BackToFrontOrder;
                    EditorUtility.SetDirty(cubisumRenderController);
                    foreach (var renderer in cubisumRenderController.Renderers)
                    {
                        EditorUtility.SetDirty(renderer);
                        // HACK Get mesh renderer directly.
                        EditorUtility.SetDirty(renderer.GetComponent<MeshRenderer>());
                    }

                    Debug.Log("Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                }
                else
                {
                    Debug.LogError("cubisumRenderController == null");
                    allComplete = false;
                }

                if (animator != null)
                {
                    Undo.RecordObject(animator, "Set AnimatorControlle to animator.runtimeAnimatorController");
                    animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Animation/Koharu_Animation");
                    EditorUtility.SetDirty(animator);

                    Debug.Log("Set AnimatorControlle to animator.runtimeAnimatorController");
                }
                else
                {
                    Debug.LogError("animator == null");
                    allComplete = false;
                }

                Live2DCubism4HeadRotationController headRotationController = FindObjectOfType<Live2DCubism4HeadRotationController>();
                if (headRotationController != null)
                {
                    Undo.RecordObject(headRotationController, "Set live2DCubism4Model to headRotationController.target");
                    headRotationController.target = live2DCubism4Model;
                    EditorUtility.SetDirty(headRotationController);

                    Debug.Log("Set live2DCubism4Model to headRotationController.target");
                }
                else
                {
                    Debug.LogError("headRotationController == null");
                    allComplete = false;
                }

                Live2DCubism4FaceAnimationController faceAnimationController = FindObjectOfType<Live2DCubism4FaceAnimationController>();
                if (faceAnimationController != null)
                {
                    Undo.RecordObject(faceAnimationController, "Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                    faceAnimationController.live2DCubism4Model = live2DCubism4Model;
                    EditorUtility.SetDirty(faceAnimationController);

                    Debug.Log("Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                }
                else
                {
                    Debug.LogError("faceAnimationController == null");
                    allComplete = false;
                }

                Live2DCubism4KeyInputExpressionController keyInputExpressionController = FindObjectOfType<Live2DCubism4KeyInputExpressionController>();
                if (keyInputExpressionController != null)
                {
                    Undo.RecordObject(keyInputExpressionController, "Set Animator to keyInputExpressionController.target");
                    keyInputExpressionController.target = animator;
                    EditorUtility.SetDirty(keyInputExpressionController);

                    Debug.Log("Set Animator to keyInputExpressionController.target");
                }
                else
                {
                    Debug.LogError("keyInputExpressionController == null");
                    allComplete = false;
                }

                if (allComplete)
                    Debug.Log("Live2DCubism4CVVTuberSettings_Koharu setup is all complete!");

            }
            else
            {
                Debug.LogError("There is no \"Live2DCubism4Model_Koharu\" prefab in the scene. Please add \"Live2DCubism4Model_Koharu\" prefab to the scene.");
            }
        }

        [MenuItem("Tools/CVVTuberExample/Setup Live2DCubism4CVVTuberExample_Rice", false, 1)]
        public static void SetLive2DCubism4CVVTuberSettings_Rice()
        {
            GameObject Rice = GameObject.Find("Rice");
            if (Rice != null)
            {

                bool allComplete = true;

                CubismModel live2DCubism4Model = Rice.GetComponent<CubismModel>();

                Animator animator = Rice.GetComponent<Animator>();


                CubismRenderController cubisumRenderController = Rice.GetComponent<CubismRenderController>();
                if (cubisumRenderController != null)
                {
                    Undo.RecordObject(cubisumRenderController, "Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                    cubisumRenderController.SortingMode = CubismSortingMode.BackToFrontOrder;
                    EditorUtility.SetDirty(cubisumRenderController);
                    foreach (var renderer in cubisumRenderController.Renderers)
                    {
                        EditorUtility.SetDirty(renderer);
                        // HACK Get mesh renderer directly.
                        EditorUtility.SetDirty(renderer.GetComponent<MeshRenderer>());
                    }

                    Debug.Log("Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                }
                else
                {
                    Debug.LogError("cubisumRenderController == null");
                    allComplete = false;
                }

                if (animator != null)
                {
                    Undo.RecordObject(animator, "Set AnimatorControlle to animator.runtimeAnimatorController");
                    animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Animation/Rice_Animation");
                    EditorUtility.SetDirty(animator);

                    Debug.Log("Set AnimatorControlle to animator.runtimeAnimatorController");
                }
                else
                {
                    Debug.LogError("animator == null");
                    allComplete = false;
                }

                Live2DCubism4HeadRotationController headRotationController = FindObjectOfType<Live2DCubism4HeadRotationController>();
                if (headRotationController != null)
                {
                    Undo.RecordObject(headRotationController, "Set live2DCubism4Model to headRotationController.target");
                    headRotationController.target = live2DCubism4Model;
                    EditorUtility.SetDirty(headRotationController);

                    Debug.Log("Set live2DCubism4Model to headRotationController.target");
                }
                else
                {
                    Debug.LogError("headRotationController == null");
                    allComplete = false;
                }

                Live2DCubism4FaceAnimationController faceAnimationController = FindObjectOfType<Live2DCubism4FaceAnimationController>();
                if (faceAnimationController != null)
                {
                    Undo.RecordObject(faceAnimationController, "Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                    faceAnimationController.live2DCubism4Model = live2DCubism4Model;
                    EditorUtility.SetDirty(faceAnimationController);

                    Debug.Log("Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                }
                else
                {
                    Debug.LogError("faceAnimationController == null");
                    allComplete = false;
                }

                Live2DCubism4KeyInputExpressionController keyInputExpressionController = FindObjectOfType<Live2DCubism4KeyInputExpressionController>();
                if (keyInputExpressionController != null)
                {
                    Undo.RecordObject(keyInputExpressionController, "Set Animator to keyInputExpressionController.target");
                    keyInputExpressionController.target = animator;
                    EditorUtility.SetDirty(keyInputExpressionController);

                    Debug.Log("Set Animator to keyInputExpressionController.target");
                }
                else
                {
                    Debug.LogError("keyInputExpressionController == null");
                    allComplete = false;
                }

                if (allComplete)
                    Debug.Log("Live2DCubism4CVVTuberSettings_Rice setup is all complete!");

            }
            else
            {
                Debug.LogError("There is no \"Live2DCubism4Model_Rice\" prefab in the scene. Please add \"Live2DCubism4Model_Rice\" prefab to the scene.");
            }
        }

        [MenuItem("Tools/CVVTuberExample/Setup Live2DCubism4CVVTuberExample_Natori", false, 1)]
        public static void SetLive2DCubism4CVVTuberSettings_Natori()
        {
            GameObject Natori = GameObject.Find("Natori");
            if (Natori != null)
            {

                bool allComplete = true;

                CubismModel live2DCubism4Model = Natori.GetComponent<CubismModel>();

                Animator animator = Natori.GetComponent<Animator>();


                CubismRenderController cubisumRenderController = Natori.GetComponent<CubismRenderController>();
                if (cubisumRenderController != null)
                {
                    Undo.RecordObject(cubisumRenderController, "Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                    cubisumRenderController.SortingMode = CubismSortingMode.BackToFrontOrder;
                    EditorUtility.SetDirty(cubisumRenderController);
                    foreach (var renderer in cubisumRenderController.Renderers)
                    {
                        EditorUtility.SetDirty(renderer);
                        // HACK Get mesh renderer directly.
                        EditorUtility.SetDirty(renderer.GetComponent<MeshRenderer>());
                    }

                    Debug.Log("Set CubismSortingMode.BackToFrontOrder to cubisumRenderController.SortingMode");
                }
                else
                {
                    Debug.LogError("cubisumRenderController == null");
                    allComplete = false;
                }

                if (animator != null)
                {
                    Undo.RecordObject(animator, "Set AnimatorControlle to animator.runtimeAnimatorController");
                    animator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Animation/Natori_Animation");
                    EditorUtility.SetDirty(animator);

                    Debug.Log("Set AnimatorControlle to animator.runtimeAnimatorController");
                }
                else
                {
                    Debug.LogError("animator == null");
                    allComplete = false;
                }

                Live2DCubism4HeadRotationController headRotationController = FindObjectOfType<Live2DCubism4HeadRotationController>();
                if (headRotationController != null)
                {
                    Undo.RecordObject(headRotationController, "Set live2DCubism4Model to headRotationController.target");
                    headRotationController.target = live2DCubism4Model;
                    EditorUtility.SetDirty(headRotationController);

                    Debug.Log("Set live2DCubism4Model to headRotationController.target");
                }
                else
                {
                    Debug.LogError("headRotationController == null");
                    allComplete = false;
                }

                Live2DCubism4FaceAnimationController faceAnimationController = FindObjectOfType<Live2DCubism4FaceAnimationController>();
                if (faceAnimationController != null)
                {
                    Undo.RecordObject(faceAnimationController, "Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                    faceAnimationController.live2DCubism4Model = live2DCubism4Model;
                    EditorUtility.SetDirty(faceAnimationController);

                    Debug.Log("Set live2DCubism4Model to faceAnimationController.live2DCubism4Model");
                }
                else
                {
                    Debug.LogError("faceAnimationController == null");
                    allComplete = false;
                }

                Live2DCubism4KeyInputExpressionController keyInputExpressionController = FindObjectOfType<Live2DCubism4KeyInputExpressionController>();
                if (keyInputExpressionController != null)
                {
                    Undo.RecordObject(keyInputExpressionController, "Set Animator to keyInputExpressionController.target");
                    keyInputExpressionController.target = animator;
                    EditorUtility.SetDirty(keyInputExpressionController);

                    Debug.Log("Set Animator to keyInputExpressionController.target");
                }
                else
                {
                    Debug.LogError("keyInputExpressionController == null");
                    allComplete = false;
                }

                if (allComplete)
                    Debug.Log("Live2DCubism4CVVTuberSettings_Natori setup is all complete!");

            }
            else
            {
                Debug.LogError("There is no \"Live2DCubism4Model_Natori\" prefab in the scene. Please add \"Live2DCubism4Model_Natori\" prefab to the scene.");
            }
        }
    }
}