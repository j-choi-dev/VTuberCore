using Live2D.Cubism.Core;
using System.Collections.Generic;
using UnityEngine;

namespace CVVTuber.Live2DCubism4
{
    public class Live2DCubism4FaceAnimationController : FaceAnimationController
    {

        [Header("[Target]")]

        public CubismModel live2DCubism4Model;

        protected CubismParameter paramEyeLOpen;

        protected CubismParameter paramEyeROpen;

        protected CubismParameter paramBrowLY;

        protected CubismParameter paramBrowRY;

        protected CubismParameter paramMouthOpenY;

        protected CubismParameter paramMouthForm;


        #region CVVTuberProcess

        public override string GetDescription()
        {
            return "Update face animation of Live2DCubism4Model using FaceLandmarkGetter.";
        }

        public override void LateUpdateValue()
        {
            if (live2DCubism4Model == null)
                return;

            if (enableEye)
            {
                if (paramEyeLOpen != null) paramEyeLOpen.Value = Mathf.Lerp(0.0f, 1.0f, EyeParam);
                if (paramEyeROpen != null) paramEyeROpen.Value = Mathf.Lerp(0.0f, 1.0f, EyeParam);
            }

            if (enableBrow)
            {
                if (paramBrowLY != null) paramBrowLY.Value = Mathf.Lerp(-1.0f, 1.0f, BrowParam);
                if (paramBrowRY != null) paramBrowRY.Value = Mathf.Lerp(-1.0f, 1.0f, BrowParam);
            }

            if (enableMouth)
            {
                if (paramMouthOpenY != null) paramMouthOpenY.Value = Mathf.Lerp(0.0f, 1.0f, MouthOpenParam);
                if (paramMouthForm != null) paramMouthForm.Value = Mathf.Lerp(-1.0f, 1.0f, MouthSizeParam);
            }
        }

        #endregion


        #region FaceAnimationController

        public override void Setup()
        {
            base.Setup();

            NullCheck(live2DCubism4Model, "live2DCubism4Model");

            paramEyeLOpen = live2DCubism4Model.Parameters.FindById("PARAM_EYE_L_OPEN");
            if (paramEyeLOpen == null) paramEyeLOpen = live2DCubism4Model.Parameters.FindById("ParamEyeLOpen");
            paramEyeROpen = live2DCubism4Model.Parameters.FindById("PARAM_EYE_R_OPEN");
            if (paramEyeROpen == null) paramEyeROpen = live2DCubism4Model.Parameters.FindById("ParamEyeROpen");
            paramBrowLY = live2DCubism4Model.Parameters.FindById("PARAM_BROW_L_Y");
            if (paramBrowLY == null) paramBrowLY = live2DCubism4Model.Parameters.FindById("ParamBrowLY");
            paramBrowRY = live2DCubism4Model.Parameters.FindById("PARAM_BROW_R_Y");
            if (paramBrowRY == null) paramBrowRY = live2DCubism4Model.Parameters.FindById("ParamBrowRY");
            paramMouthOpenY = live2DCubism4Model.Parameters.FindById("PARAM_MOUTH_OPEN_Y");
            if (paramMouthOpenY == null) paramMouthOpenY = live2DCubism4Model.Parameters.FindById("ParamMouthOpenY");
            paramMouthForm = live2DCubism4Model.Parameters.FindById("PARAM_MOUTH_FORM");
            if (paramMouthForm == null) paramMouthForm = live2DCubism4Model.Parameters.FindById("ParamMouthForm");
        }

        protected override void UpdateFaceAnimation(List<Vector2> points)
        {
            if (enableEye)
            {
                float eyeOpen = (GetLeftEyeOpenRatio(points) + GetRightEyeOpenRatio(points)) / 2.0f;
                //Debug.Log ("eyeOpen " + eyeOpen);

                if (eyeOpen >= 0.88f)
                {
                    eyeOpen = 1.0f;
                }
                else if (eyeOpen >= 0.45f)
                {
                    eyeOpen = 0.5f;
                }
                else if (eyeOpen >= 0.25f)
                {
                    eyeOpen = 0.2f;
                }
                else
                {
                    eyeOpen = 0.0f;
                }

                EyeParam = Mathf.Lerp(EyeParam, eyeOpen, eyeLeapT);
            }

            if (enableBrow)
            {
                float browOpen = (GetLeftEyebrowUPRatio(points) + GetRightEyebrowUPRatio(points)) / 2.0f;
                //Debug.Log("browOpen " + browOpen);

                if (browOpen >= 0.75f)
                {
                    browOpen = 1.0f;
                }
                else if (browOpen >= 0.4f)
                {
                    browOpen = 0.5f;
                }
                else
                {
                    browOpen = 0.0f;
                }
                BrowParam = Mathf.Lerp(BrowParam, browOpen, browLeapT);
            }

            if (enableMouth)
            {
                float mouthOpen = GetMouthOpenYRatio(points);
                //Debug.Log("mouthOpen " + mouthOpen);

                if (mouthOpen >= 0.7f)
                {
                    mouthOpen = 1.0f;
                }
                else if (mouthOpen >= 0.25f)
                {
                    mouthOpen = 0.5f;
                }
                else
                {
                    mouthOpen = 0.0f;
                }
                MouthOpenParam = Mathf.Lerp(MouthOpenParam, mouthOpen, mouthLeapT);


                float mouthSize = GetMouthOpenXRatio(points);
                //Debug.Log("mouthSize " + mouthSize);

                if (mouthSize >= 0.5f)
                {
                    mouthSize = 1.0f;
                }
                else
                {
                    mouthSize = 0.0f;
                }
                MouthSizeParam = Mathf.Lerp(MouthSizeParam, mouthSize, mouthLeapT);
            }
        }

        #endregion

    }
}