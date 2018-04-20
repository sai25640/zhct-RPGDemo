//----------------------------------------------
//            Shader Weaver
//      Copyright© 2017 Jackie Lo
//----------------------------------------------
namespace ShaderWeaver
{
	using UnityEngine;
	using System.Collections;
	using UnityEditor;
	using System;

	[System.Serializable]
	public class SWNodeRemap :SWNodeBase {
		[SerializeField]
		public Texture2D texChildOrigin;
		[SerializeField]
		public SWTexture2DEx texChildResized;

		public override void Init (SWDataNode _data, SWWindowMain _window)
		{
			childPortSingleConnection = true;
			styleID = 2;
			base.Init (_data, _window);
			data.outputType.Add (SWDataType._UV);
			data.inputType.Add (SWDataType._Color);

			if (textureEx.IsNull)
				ResetTex ();
		}

		public override bool PortMatch (int port, SWNodeBase child, int childPort)
		{
			return base.PortMatch (port, child, childPort) && (child.data.type == SWNodeType.image || child.data.type == SWNodeType.dummy);
		}

		void ResetTex()
		{
			textureEx = SWCommon.TextureCreate( data.resolution,data.resolution,TextureFormat.ARGB32);
		}

		protected override void DrawHead ()
		{
			base.DrawHead ();
		}

		protected override void DrawNodeWindow (int id)
		{
			base.DrawNodeWindow (id);
			if (data.useCustomTexture) {
				DrawWinCustom (id);
			} else {
				DrawWin (id);
			}
		}

		void DrawWin(int id)
		{
			base.DrawNodeWindow (id);
			if (GetChildTexture () != null) {
				if (texChildOrigin != GetChildTexture ()) {
					UpdateTex ();
				}
				if (textureEx != null) {
					GUI.DrawTexture (rectArea, textureEx.Texture, ScaleMode.StretchToFill);
				}  


				if (GUI.Button (new Rect(rectBotButton.x,rectBotButton.y,rectBotButton.width- buttonHeight,rectBotButton.height),"Edit",SWEditorUI.MainSkin.button)) {
					SWWindowDrawRemap.ShowEditor (this);
				}
				if (GUI.Button (new Rect(rectBotButton.x+rectBotButton.width - buttonHeight,rectBotButton.y,buttonHeight,rectBotButton.height),"+",SWEditorUI.MainSkin.button)) {
					data.useCustomTexture = !data.useCustomTexture;
				}
			}

			DrawNodeWindowEnd ();
		}

		void DrawWinCustom(int id)
		{
			base.DrawNodeWindow (id);
			SelectTexture ();
			if (GUI.Button (rectBotButton,"Switch",SWEditorUI.MainSkin.button)) {
				data.useCustomTexture = !data.useCustomTexture;
				if (!data.useCustomTexture)
					ResetTex ();
			}
			DrawNodeWindowEnd ();
		}



		public void UpdateTex()
		{  
			texChildOrigin = GetChildTexture();
			texChildResized = SWTextureProcess.TextureResize (texChildOrigin,  data.resolution,  data.resolution);
			texChildResized.filterMode = FilterMode.Point;
		}
		public override void DrawSelection ()  
		{
			base.DrawSelection ();
		}


		#region save load
		public override void BeforeSave ()
		{
			base.BeforeSave ();
		}

		public override void AfterLoad ()
		{
			base.AfterLoad ();
			if (GetChildTexture () != null) {
				texChildOrigin = GetChildTexture();
				texChildResized = SWTextureProcess.TextureResize (texChildOrigin, data.resolution, data.resolution);
			}
			DrawNodeWindowEnd ();
		}
		#endregion
	}
}