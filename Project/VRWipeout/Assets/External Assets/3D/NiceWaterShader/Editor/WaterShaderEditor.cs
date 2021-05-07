using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class WaterShaderEditor : ShaderGUI {

	bool showCustomInspector = true;

	//ColorFoldoutProperties
	bool colorFoldout = true;
	Color depthColor0;
	Color depthColor1;
	Color depthColor2;
	float colorPosition0;
	float colorPosition1;
	Color fresnelColor;
	float fresnelExponent;
	float opacity;
	float opacityDepth;
	bool isSpecularNormalIntensity;
	float specularExponent;
	float specularIntensity;
	bool normals;
	float normalsIntensity;
	float normalsScale;

	//Foams Foldout
	bool foamFoldout = true;
	Color foamColor;
	bool mainFoamPower;
	float mainFoamDistance;
	float mainFoamOpacity;
	float mainFoamScale;
	float mainFoamSpeed;
	float secondaryFoamIntensity;
	float secondaryFoamDistance;
	float secondaryFoamScale;
	float secondaryFoamSpeed;

	//Vertex Foldout
	bool wavesFoldout = true;
	bool vertexOffset;
	float wavesAmplitude;
	float wavesIntensity;
	float wavesSpeed;

	//RealtimeReflections foldout
	bool realtimeReflectionsFoldout = true;
	bool realtimeReflections;
	float reflectionIntensity;
	float turbulenceScale;
	float turbulenceDistortionIntensity;
	float waveDistortionIntensity;

	//Textures foldout
	bool texturesFoldout = true;
	Texture2D wavesNormalTexture;
	Vector2 wavesNormalTextureTiling;
	Texture2D foamTexture;
	Vector2 foamTextureTiling;
	Texture2D reflectionTexture;
	Vector2 reflectionTextureTiling;

	//CustomAssets
	bool cache;
	Font customFont;
	Texture titleTex;
	Texture colorTex;
	Texture foamTex;
	Texture reflectionsTex;
	Texture wavesTex;
	Texture texturesTex;
	GUIStyle foldoutTitleStyle;
	GUILayoutOption[] colorsLayout;
	GUIStyle titleColorStyle;

	void GetCache()
	{
		if (cache == false)
		{
			cache = true;
			#region SetCustomAssets
			//CustomFont
			customFont = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Simple.ttf", typeof(Font)) as Font;
			//TitleImage
			titleTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Title.png", typeof(Texture2D)) as Texture2D;
			//ColorsImage
			colorTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Colors.png", typeof(Texture2D)) as Texture2D;
			//FoamImage
			foamTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Foams.png", typeof(Texture2D)) as Texture2D;
			//ReflectionsImage
			reflectionsTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Reflections.png", typeof(Texture2D)) as Texture2D;
			//WavesImage
			wavesTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Waves.png", typeof(Texture2D)) as Texture2D;
			//TexturesImage
			texturesTex = AssetDatabase.LoadAssetAtPath(GetAssetPath() + "Interface/Textures.png", typeof(Texture2D)) as Texture2D;
			#endregion
			#region GUIStyles Templates
			//Foldouts
			foldoutTitleStyle = new GUIStyle("Foldout");
			foldoutTitleStyle.font = customFont;
			foldoutTitleStyle.fontSize = 20;
			foldoutTitleStyle.fixedHeight = 20;
			foldoutTitleStyle.margin.left = 15;
			//Option
			colorsLayout = new GUILayoutOption[4];
			colorsLayout[0] = GUILayout.MaxHeight(40);
			colorsLayout[1] = GUILayout.MinHeight(20);
			colorsLayout[2] = GUILayout.MinWidth(20);
			colorsLayout[3] = GUILayout.MaxWidth(500);
			//Titles
			titleColorStyle = new GUIStyle("label") { alignment = TextAnchor.MiddleCenter, fontSize = 13, fontStyle = FontStyle.Bold };
			#endregion
		}
	}
	public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
	{
		showCustomInspector = EditorGUILayout.Toggle("Use Custom Inspector", showCustomInspector);
		if (!showCustomInspector)
		{
			base.OnGUI(materialEditor, properties);
		}
		else
		{
			EditorGUI.BeginChangeCheck();
			Material targetMat = materialEditor.target as Material;
			Undo.RecordObject(targetMat, null);
			GetCache();
			#region TitleImage
			GUIContent title = new GUIContent(titleTex);
			GUILayoutOption[] titleOptions = new GUILayoutOption[2];
			titleOptions[0] = GUILayout.MaxWidth(150);
			titleOptions[1] = GUILayout.MaxHeight(150);
			//Draw
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.Label(title, titleOptions);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			#endregion
			#region Colors Foldout
			GUIContent colorFoldoutTitle = new GUIContent("Colors", colorTex);
			GUILayout.BeginHorizontal("box");
			GUILayout.BeginVertical();
			colorFoldout = EditorGUILayout.Foldout(colorFoldout, colorFoldoutTitle, true, foldoutTitleStyle);
			GUILayout.Space(10);

			if (colorFoldout)
			{
				GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
				depthColor0 = EditorGUILayout.ColorField(new GUIContent(""), targetMat.GetColor("_DepthColor0"), false, false, false, colorsLayout);
				depthColor1 = EditorGUILayout.ColorField(new GUIContent(""), targetMat.GetColor("_DepthColor1"), false, false, false, colorsLayout);
				depthColor2 = EditorGUILayout.ColorField(new GUIContent(""), targetMat.GetColor("_DepthColor2"), false, false, false, colorsLayout);
				GUILayout.EndHorizontal();
				colorPosition0 = EditorGUILayout.Slider("First Color Position", targetMat.GetFloat("_ColorPosition0"), 0, 10);
				colorPosition1 = EditorGUILayout.Slider("Secondary Color Position", targetMat.GetFloat("_ColorPosition1"), 0, 10);

				GUILayout.Space(10);

				//Fresnel Color
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Fresnel Color", titleColorStyle, GUILayout.ExpandWidth(true));
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
				fresnelColor = EditorGUILayout.ColorField(new GUIContent(""), targetMat.GetColor("_FresnelColor"), false, false, false, colorsLayout);
				GUILayout.EndHorizontal();
				fresnelExponent = EditorGUILayout.Slider("Fresnel Exponent", targetMat.GetFloat("_FresnelExponent"), 0, 10);

				GUILayout.Space(10);

				//SurfaceOptions
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Surface Options", titleColorStyle, GUILayout.ExpandWidth(true));
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				opacity = EditorGUILayout.Slider("Opacity", targetMat.GetFloat("_Opacity"), 0, 1);
				opacityDepth = EditorGUILayout.FloatField("Opacity Depth", targetMat.GetFloat("_DepthOpacity"));
				bool SNIB = true;
				if(targetMat.GetFloat("_isSpecularNormalIntensity") == 0) { SNIB = false; } else { SNIB = true; }
				isSpecularNormalIntensity = EditorGUILayout.Toggle("Specular Normal Intensity", SNIB);
				specularExponent = EditorGUILayout.Slider("Specular Exponent", targetMat.GetFloat("_SpecularExponent"), 0, 1);
				specularIntensity = EditorGUILayout.Slider("Specular Intensity", targetMat.GetFloat("_SpecularIntensity"), 0, 1);
				bool NB = true;
				if (targetMat.GetFloat("_Normals") == 0) { NB = false; } else { NB = true; }
				normals = EditorGUILayout.Toggle("Normals", NB);
				normalsIntensity = EditorGUILayout.Slider("Normals Intensity", targetMat.GetFloat("_NormalsIntensity"), 0, 5);
				normalsScale = EditorGUILayout.FloatField("Normals Scale", targetMat.GetFloat("_NormalsScale"));
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			#endregion
			#region Foams Foldout
			GUIContent foamFoldoutTitle = new GUIContent("Foams", foamTex);
			GUILayout.BeginHorizontal("box");
			GUILayout.BeginVertical();
			foamFoldout = EditorGUILayout.Foldout(foamFoldout, foamFoldoutTitle, true, foldoutTitleStyle);
			GUILayout.Space(10);

			if (foamFoldout)
			{
				GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
				foamColor = EditorGUILayout.ColorField(new GUIContent(""), targetMat.GetColor("_FoamColor"), false, false, false, colorsLayout);
				GUILayout.EndHorizontal();
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Main Foam", titleColorStyle, GUILayout.ExpandWidth(true));
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				bool MFPB = true;
				if (targetMat.GetFloat("_MainFoamPower") == 0) { MFPB = false; } else { MFPB = true; }
				mainFoamPower = EditorGUILayout.Toggle("Main Foam Power", MFPB);
				mainFoamDistance = EditorGUILayout.Slider("Foam Distance", targetMat.GetFloat("_MainFoamDistance"), 0, 10);
				mainFoamOpacity = EditorGUILayout.Slider("Foam Opacity", targetMat.GetFloat("_MainFoamOpacity"), 0, 1);
				mainFoamScale = EditorGUILayout.FloatField("Foam Scale", targetMat.GetFloat("_MainFoamScale"));
				mainFoamSpeed = EditorGUILayout.FloatField("Foam Speed", targetMat.GetFloat("_MainFoamSpeed"));
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Secondary Foam", titleColorStyle, GUILayout.ExpandWidth(true));
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				secondaryFoamIntensity = EditorGUILayout.Slider("Foam Intensity", targetMat.GetFloat("_SecondaryFoamIntensity"), 0, 1);
				secondaryFoamDistance = EditorGUILayout.Slider("Foam Distance", targetMat.GetFloat("_SecondaryFoamDistance"), 0, 10);
				secondaryFoamScale = EditorGUILayout.FloatField("Foam Scale", targetMat.GetFloat("_SecondaryFoamScale"));
				secondaryFoamSpeed = EditorGUILayout.FloatField("Foam Speed", targetMat.GetFloat("_SecondaryFoamSpeed"));
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			#endregion
			#region Waves
			GUIContent wavesFoldoutTitle = new GUIContent("Waves", wavesTex);
			GUILayout.BeginHorizontal("box");
			GUILayout.BeginVertical();
			wavesFoldout = EditorGUILayout.Foldout(wavesFoldout, wavesFoldoutTitle, true, foldoutTitleStyle);
			GUILayout.Space(10);

			if (wavesFoldout)
			{
				bool VOB = true;
				if (targetMat.GetFloat("_VertexOffset") == 0) { VOB = false; } else { VOB = true; }
				vertexOffset = EditorGUILayout.Toggle("Vertex Offset", VOB);
				wavesAmplitude = EditorGUILayout.Slider("Waves Amplitude", targetMat.GetFloat("_WavesAmplitude"), 0, 10);
				wavesIntensity = EditorGUILayout.FloatField("Waves Intensity", targetMat.GetFloat("_WavesIntensity"));
				wavesSpeed = EditorGUILayout.FloatField("Waves Speed", targetMat.GetFloat("_WavesSpeed"));
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			#endregion
			#region RealtimeReflections
			GUIContent rrFoldoutTitle = new GUIContent("Reflections", reflectionsTex);
			GUILayout.BeginHorizontal("box");
			GUILayout.BeginVertical();
			realtimeReflectionsFoldout = EditorGUILayout.Foldout(realtimeReflectionsFoldout, rrFoldoutTitle, true, foldoutTitleStyle);
			GUILayout.Space(10);

			if (realtimeReflectionsFoldout)
			{
				bool RRB = true;
				if (targetMat.GetFloat("_RealtimeReflections") == 0) { RRB = false; } else { RRB = true; }
				realtimeReflections = EditorGUILayout.Toggle("Realtime Reflections", RRB);
				reflectionIntensity = EditorGUILayout.Slider("Reflections Intensity", targetMat.GetFloat("_ReflectionsIntensity"), 0, 3);
				turbulenceScale = EditorGUILayout.FloatField("Turbulence Scale", targetMat.GetFloat("_TurbulenceScale"));
				turbulenceDistortionIntensity = EditorGUILayout.Slider("TurbulenceDistortionIntensity", targetMat.GetFloat("_TurbulenceDistortionIntensity"), 0, 6);
				waveDistortionIntensity = EditorGUILayout.Slider("Wave Distortion Intensity", targetMat.GetFloat("_WaveDistortionIntensity"), 0, 4);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			#endregion
			#region Textures
			GUIContent texturesFoldoutTitle = new GUIContent("Textures", texturesTex);
			GUILayout.BeginHorizontal("box");
			GUILayout.BeginVertical();
			texturesFoldout = EditorGUILayout.Foldout(texturesFoldout, texturesFoldoutTitle, true, foldoutTitleStyle);
			GUILayout.Space(10);

			if (texturesFoldout)
			{
				wavesNormalTextureTiling = EditorGUILayout.Vector2Field("WavesNormal Tiling", targetMat.GetTextureScale("_WavesNormal"));
				wavesNormalTexture = EditorGUILayout.ObjectField("WavesNormal Texture", targetMat.GetTexture("_WavesNormal"), typeof(Texture2D),false) as Texture2D;
				foamTextureTiling = EditorGUILayout.Vector2Field("FoamTexture Tiling", targetMat.GetTextureScale("_FoamTexture"));
				foamTexture = EditorGUILayout.ObjectField("Foam Texture", targetMat.GetTexture("_FoamTexture"), typeof(Texture2D), false) as Texture2D;
				EditorGUILayout.HelpBox("Reflection texture is automatically set when the WaterReflections script is set on this same GameObject", MessageType.Info);
				reflectionTextureTiling = EditorGUILayout.Vector2Field("ReflectionsTexture Tiling", targetMat.GetTextureScale("_ReflectionTex"));
				reflectionTexture = EditorGUILayout.ObjectField("Reflections Texture", targetMat.GetTexture("_ReflectionTex"), typeof(Texture2D), false) as Texture2D;
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			#endregion

			if (EditorGUI.EndChangeCheck() || (Event.current.type == EventType.ValidateCommand && Event.current.commandName == "UndoRedoPerformed"))
			{
				targetMat.SetColor("_DepthColor0", depthColor0);
				targetMat.SetColor("_DepthColor1", depthColor1);
				targetMat.SetColor("_DepthColor2", depthColor2);
				targetMat.SetFloat("_ColorPosition0", colorPosition0);
				targetMat.SetFloat("_ColorPosition1", colorPosition1);
				targetMat.SetColor("_FresnelColor", fresnelColor);
				targetMat.SetFloat("_FresnelExponent", fresnelExponent);

				targetMat.SetFloat("_Opacity", opacity);
				targetMat.SetFloat("_DepthOpacity", opacityDepth);
				if (isSpecularNormalIntensity) { targetMat.EnableKeyword("_ISSPECULARNORMALINTENSITY_ON"); targetMat.SetFloat("_isSpecularNormalIntensity", 1); } else { targetMat.DisableKeyword("_ISSPECULARNORMALINTENSITY_ON"); targetMat.SetFloat("_isSpecularNormalIntensity", 0); }
				targetMat.SetFloat("_SpecularExponent", specularExponent);
				targetMat.SetFloat("_SpecularIntensity", specularIntensity);
				if (normals) { targetMat.EnableKeyword("_NORMALS_ON"); targetMat.SetFloat("_Normals", 1); } else { targetMat.DisableKeyword("_NORMALS_ON"); targetMat.SetFloat("_Normals", 0); }
				targetMat.SetFloat("_NormalsIntensity", normalsIntensity);
				targetMat.SetFloat("_NormalsScale", normalsScale);

				//Foams
				targetMat.SetColor("_FoamColor", foamColor);
				if (mainFoamPower) { targetMat.EnableKeyword("_MAINFOAMPOWER_ON"); targetMat.SetFloat("_MainFoamPower", 1); } else { targetMat.DisableKeyword("_MAINFOAMPOWER_ON"); targetMat.SetFloat("_MainFoamPower", 0); }
				targetMat.SetFloat("_MainFoamDistance", mainFoamDistance);
				targetMat.SetFloat("_MainFoamOpacity", mainFoamOpacity);
				targetMat.SetFloat("_MainFoamScale", mainFoamScale);
				targetMat.SetFloat("_MainFoamSpeed", mainFoamSpeed);
				targetMat.SetFloat("_SecondaryFoamIntensity", secondaryFoamIntensity);
				targetMat.SetFloat("_SecondaryFoamDistance", secondaryFoamDistance);
				targetMat.SetFloat("_SecondaryFoamScale", secondaryFoamScale);
				targetMat.SetFloat("_SecondaryFoamSpeed", secondaryFoamSpeed);

				//VertexOffset
				if (vertexOffset) { targetMat.EnableKeyword("_VERTEXOFFSET_ON"); targetMat.SetFloat("_VertexOffset", 1); } else {targetMat.DisableKeyword("_VERTEXOFFSET_ON"); targetMat.SetFloat("_VertexOffset", 0); }
				targetMat.SetFloat("_WavesAmplitude", wavesAmplitude);
				targetMat.SetFloat("_WavesIntensity", wavesIntensity);
				targetMat.SetFloat("_WavesSpeed", wavesSpeed);

				//RealtimeReflections
				if (realtimeReflections) { targetMat.EnableKeyword("_REALTIMEREFLECTIONS_ON"); targetMat.SetFloat("_RealtimeReflections", 1); } else { targetMat.DisableKeyword("_REALTIMEREFLECTIONS_ON"); targetMat.SetFloat("_RealtimeReflections", 0); }
				targetMat.SetFloat("_ReflectionsIntensity", reflectionIntensity);
				targetMat.SetFloat("_TurbulenceScale", turbulenceScale);
				targetMat.SetFloat("_TurbulenceDistortionIntensity", turbulenceDistortionIntensity);
				targetMat.SetFloat("_WaveDistortionIntensity", waveDistortionIntensity);

				//Textures
				targetMat.SetTexture("_WavesNormal", wavesNormalTexture);
				targetMat.SetTextureScale("_WavesNormal", wavesNormalTextureTiling);
				targetMat.SetTexture("_FoamTexture", foamTexture);
				targetMat.SetTextureScale("_FoamTexture", foamTextureTiling);
				targetMat.SetTexture("_ReflectionTex", reflectionTexture);
				targetMat.SetTextureScale("_ReflectionTex", reflectionTextureTiling);
			}
		}
	}
	string GetAssetPath()
	{
		string name = this.ToString();
		string[] temp = AssetDatabase.FindAssets(name, null);
		return AssetDatabase.GUIDToAssetPath(temp[0]).Remove(AssetDatabase.GUIDToAssetPath(temp[0]).Length - (name.Length + 3));
	}
}
