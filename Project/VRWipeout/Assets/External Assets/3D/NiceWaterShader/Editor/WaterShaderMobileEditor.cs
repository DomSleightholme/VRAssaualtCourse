using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class WaterShaderMobileEditor : ShaderGUI {

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

	//Textures foldout
	bool texturesFoldout = true;
	Texture2D wavesNormalTexture;
	Vector2 wavesNormalTextureTiling;
	Texture2D foamTexture;
	Vector2 foamTextureTiling;

	//CustomAssets
	bool cache;
	Font customFont;
	Texture titleTex;
	Texture colorTex;
	Texture foamTex;
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
				if (normals) { targetMat.SetFloat("_Normals", 1); } else { targetMat.SetFloat("_Normals", 0); }
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

				//Textures
				targetMat.SetTexture("_WavesNormal", wavesNormalTexture);
				targetMat.SetTextureScale("_WavesNormal", wavesNormalTextureTiling);
				targetMat.SetTexture("_FoamTexture", foamTexture);
				targetMat.SetTextureScale("_FoamTexture", foamTextureTiling);
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
