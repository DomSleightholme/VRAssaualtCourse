// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:True,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33955,y:32812,varname:node_3138,prsc:2|normal-7153-OUT,emission-9911-OUT,custl-6604-OUT,alpha-2181-OUT,refract-1901-OUT,voffset-8049-OUT,tess-2381-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31360,y:31657,ptovrint:False,ptlb:DepthColor0,ptin:_DepthColor0,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2566305,c2:0.745283,c3:0.7131348,c4:1;n:type:ShaderForge.SFN_Color,id:9596,x:31100,y:31559,ptovrint:False,ptlb:DepthColor1,ptin:_DepthColor1,varname:node_9596,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2862745,c2:0.4470589,c3:0.7176471,c4:1;n:type:ShaderForge.SFN_Color,id:5666,x:31100,y:31721,ptovrint:False,ptlb:DepthColor2,ptin:_DepthColor2,varname:node_5666,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1793343,c2:0.2083115,c3:0.4352941,c4:1;n:type:ShaderForge.SFN_Lerp,id:3137,x:31604,y:31787,varname:node_3137,prsc:2|A-7241-RGB,B-5259-OUT,T-2769-OUT;n:type:ShaderForge.SFN_DepthBlend,id:2769,x:31360,y:31954,varname:node_2769,prsc:2|DIST-3572-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3572,x:30761,y:32007,ptovrint:False,ptlb:ColorPosition0,ptin:_ColorPosition0,varname:node_3572,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Lerp,id:5259,x:31360,y:31818,varname:node_5259,prsc:2|A-9596-RGB,B-5666-RGB,T-9738-OUT;n:type:ShaderForge.SFN_Add,id:9837,x:30956,y:31859,varname:node_9837,prsc:2|A-3572-OUT,B-2887-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2887,x:30761,y:31888,ptovrint:False,ptlb:ColorPosition1,ptin:_ColorPosition1,varname:node_2887,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_DepthBlend,id:9738,x:31122,y:31859,varname:node_9738,prsc:2|DIST-9837-OUT;n:type:ShaderForge.SFN_Color,id:4409,x:31604,y:31968,ptovrint:False,ptlb:FresnelColor,ptin:_FresnelColor,varname:node_4409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4861605,c2:0.8962264,c3:0.8699822,c4:1;n:type:ShaderForge.SFN_Lerp,id:9479,x:31957,y:31951,varname:node_9479,prsc:2|A-3137-OUT,B-4409-RGB,T-3690-OUT;n:type:ShaderForge.SFN_Fresnel,id:3690,x:31604,y:32134,varname:node_3690,prsc:2|EXP-3355-OUT;n:type:ShaderForge.SFN_Slider,id:3355,x:31254,y:32158,ptovrint:False,ptlb:FresnelExponent,ptin:_FresnelExponent,varname:node_3355,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:8.441893,max:10;n:type:ShaderForge.SFN_Tex2dAsset,id:1033,x:29131,y:32600,ptovrint:False,ptlb:WavesNormal,ptin:_WavesNormal,varname:node_1033,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8322b723f17dc4a4a8a5dbddb0f787c7,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:8799,x:31847,y:33274,varname:node_8799,prsc:2|A-9666-B,B-5699-OUT;n:type:ShaderForge.SFN_Tex2d,id:9666,x:31660,y:33274,varname:node_9666,prsc:2,tex:8322b723f17dc4a4a8a5dbddb0f787c7,ntxv:0,isnm:False|TEX-1033-TEX;n:type:ShaderForge.SFN_Slider,id:2975,x:31326,y:33405,ptovrint:False,ptlb:WavesAmplitude,ptin:_WavesAmplitude,varname:node_2975,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10,max:10;n:type:ShaderForge.SFN_Vector1,id:4686,x:31483,y:33484,varname:node_4686,prsc:2,v1:30;n:type:ShaderForge.SFN_Multiply,id:5699,x:31660,y:33405,varname:node_5699,prsc:2|A-2975-OUT,B-4686-OUT;n:type:ShaderForge.SFN_Time,id:3850,x:31660,y:33069,varname:node_3850,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:6437,x:31660,y:33213,ptovrint:False,ptlb:Waves Speed,ptin:_WavesSpeed,varname:node_6437,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9168,x:31847,y:33153,varname:node_9168,prsc:2|A-3850-T,B-6437-OUT;n:type:ShaderForge.SFN_Subtract,id:6203,x:32029,y:33234,varname:node_6203,prsc:2|A-9168-OUT,B-8799-OUT;n:type:ShaderForge.SFN_Sin,id:2235,x:32190,y:33234,varname:node_2235,prsc:2|IN-6203-OUT;n:type:ShaderForge.SFN_Multiply,id:7594,x:32375,y:33269,varname:node_7594,prsc:2|A-2235-OUT,B-5136-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5136,x:32190,y:33386,ptovrint:False,ptlb:WavesIntensity,ptin:_WavesIntensity,varname:node_5136,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9938,x:32596,y:33269,varname:node_9938,prsc:2|A-3301-OUT,B-7594-OUT;n:type:ShaderForge.SFN_NormalVector,id:3301,x:32190,y:33076,prsc:2,pt:False;n:type:ShaderForge.SFN_SwitchProperty,id:8049,x:32969,y:33302,ptovrint:False,ptlb:VertexOffset,ptin:_VertexOffset,varname:node_8049,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-6925-OUT,B-9938-OUT;n:type:ShaderForge.SFN_Vector1,id:6925,x:32596,y:33200,varname:node_6925,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:9052,x:32859,y:32377,varname:node_9052,prsc:2|A-7657-OUT,B-3858-OUT,C-6103-OUT;n:type:ShaderForge.SFN_DepthBlend,id:6120,x:31241,y:32421,varname:node_6120,prsc:2|DIST-3714-OUT;n:type:ShaderForge.SFN_OneMinus,id:2957,x:31885,y:32420,varname:node_2957,prsc:2|IN-9655-OUT;n:type:ShaderForge.SFN_Multiply,id:1353,x:32072,y:32420,varname:node_1353,prsc:2|A-2957-OUT,B-4845-OUT;n:type:ShaderForge.SFN_Slider,id:4845,x:31616,y:32610,ptovrint:False,ptlb:MainFoamOpacity,ptin:_MainFoamOpacity,varname:node_4845,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9249998,max:1;n:type:ShaderForge.SFN_Color,id:315,x:31885,y:32212,ptovrint:False,ptlb:FoamColor,ptin:_FoamColor,varname:node_315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:3858,x:32253,y:32310,varname:node_3858,prsc:2|A-315-RGB,B-1353-OUT;n:type:ShaderForge.SFN_RemapRange,id:7395,x:30857,y:32421,varname:node_7395,prsc:2,frmn:0,frmx:1,tomn:0.2,tomx:0.3|IN-2235-OUT;n:type:ShaderForge.SFN_Multiply,id:3714,x:31048,y:32421,varname:node_3714,prsc:2|A-7395-OUT,B-2185-OUT;n:type:ShaderForge.SFN_Multiply,id:2185,x:30857,y:32589,varname:node_2185,prsc:2|A-276-R,B-6346-OUT;n:type:ShaderForge.SFN_Tex2d,id:276,x:30657,y:32572,varname:node_276,prsc:2,tex:8cc1863f1aa7e2e418da68cae212ffc7,ntxv:0,isnm:False|UVIN-3784-OUT,TEX-2583-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2583,x:30414,y:32774,ptovrint:False,ptlb:FoamTexture,ptin:_FoamTexture,varname:node_2583,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8cc1863f1aa7e2e418da68cae212ffc7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:6346,x:30700,y:32742,ptovrint:False,ptlb:Main Foam Distance,ptin:_MainFoamDistance,varname:node_6346,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:7.420634,max:10;n:type:ShaderForge.SFN_TexCoord,id:704,x:30094,y:32617,varname:node_704,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:289,x:30094,y:32784,ptovrint:False,ptlb:Main FoamScale,ptin:_MainFoamScale,varname:node_289,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_Multiply,id:3191,x:30273,y:32617,varname:node_3191,prsc:2|A-704-UVOUT,B-289-OUT;n:type:ShaderForge.SFN_Time,id:446,x:30105,y:32489,varname:node_446,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:3159,x:30105,y:32440,ptovrint:False,ptlb:Main FoamSpeed,ptin:_MainFoamSpeed,varname:node_3159,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:21,x:30273,y:32489,varname:node_21,prsc:2|A-3159-OUT,B-446-T;n:type:ShaderForge.SFN_Add,id:3784,x:30453,y:32572,varname:node_3784,prsc:2|A-21-OUT,B-3191-OUT;n:type:ShaderForge.SFN_Power,id:5881,x:31443,y:32468,varname:node_5881,prsc:2|VAL-6120-OUT,EXP-1958-OUT;n:type:ShaderForge.SFN_Vector1,id:1958,x:31243,y:32600,varname:node_1958,prsc:2,v1:15;n:type:ShaderForge.SFN_Clamp01,id:5124,x:31616,y:32468,varname:node_5124,prsc:2|IN-5881-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:9655,x:31715,y:32342,ptovrint:False,ptlb:MainFoamPower,ptin:_MainFoamPower,varname:node_9655,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-6120-OUT,B-5124-OUT;n:type:ShaderForge.SFN_Tex2d,id:3520,x:31143,y:32897,varname:node_3520,prsc:2,tex:8cc1863f1aa7e2e418da68cae212ffc7,ntxv:0,isnm:False|UVIN-6661-OUT,TEX-2583-TEX;n:type:ShaderForge.SFN_Multiply,id:1468,x:31773,y:32740,varname:node_1468,prsc:2|A-3520-R,B-7781-OUT;n:type:ShaderForge.SFN_Slider,id:7781,x:31337,y:32943,ptovrint:False,ptlb:SecondaryFoamIntensity,ptin:_SecondaryFoamIntensity,varname:node_7781,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3,max:1;n:type:ShaderForge.SFN_Slider,id:4000,x:30700,y:32833,ptovrint:False,ptlb:SecondaryFoamDistance,ptin:_SecondaryFoamDistance,varname:node_4000,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:10;n:type:ShaderForge.SFN_DepthBlend,id:1282,x:31291,y:32712,varname:node_1282,prsc:2|DIST-4000-OUT;n:type:ShaderForge.SFN_OneMinus,id:7394,x:31457,y:32712,varname:node_7394,prsc:2|IN-1282-OUT;n:type:ShaderForge.SFN_Multiply,id:8635,x:31991,y:32740,varname:node_8635,prsc:2|A-7394-OUT,B-1468-OUT;n:type:ShaderForge.SFN_Multiply,id:6103,x:32443,y:32595,varname:node_6103,prsc:2|A-315-RGB,B-8635-OUT;n:type:ShaderForge.SFN_TexCoord,id:8369,x:30087,y:33047,varname:node_8369,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:2487,x:30087,y:33214,ptovrint:False,ptlb:SecondaryFoamScale,ptin:_SecondaryFoamScale,varname:_FoamScale_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_Multiply,id:8205,x:30266,y:33047,varname:node_8205,prsc:2|A-8369-UVOUT,B-2487-OUT;n:type:ShaderForge.SFN_Time,id:4230,x:30098,y:32919,varname:node_4230,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7355,x:30098,y:32870,ptovrint:False,ptlb:SecondaryFoamSpeed,ptin:_SecondaryFoamSpeed,varname:_FoamSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:7541,x:30266,y:32919,varname:node_7541,prsc:2|A-7355-OUT,B-4230-T;n:type:ShaderForge.SFN_Add,id:6661,x:30446,y:33002,varname:node_6661,prsc:2|A-7541-OUT,B-8205-OUT;n:type:ShaderForge.SFN_Tex2d,id:6108,x:29653,y:31780,varname:node_6108,prsc:2,tex:8322b723f17dc4a4a8a5dbddb0f787c7,ntxv:0,isnm:False|UVIN-6326-UVOUT,TEX-1033-TEX;n:type:ShaderForge.SFN_TexCoord,id:426,x:29014,y:31764,varname:node_426,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4942,x:29236,y:31764,varname:node_4942,prsc:2|A-426-UVOUT,B-9979-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9979,x:29014,y:31960,ptovrint:False,ptlb:TurbulenceScale,ptin:_TurbulenceScale,varname:node_9979,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Panner,id:6326,x:29437,y:31783,varname:node_6326,prsc:2,spu:0.01,spv:0.01|UVIN-4942-OUT;n:type:ShaderForge.SFN_Multiply,id:4126,x:30114,y:31851,varname:node_4126,prsc:2|A-6108-G,B-5316-OUT;n:type:ShaderForge.SFN_Slider,id:5316,x:29642,y:31994,ptovrint:False,ptlb:Turbulence Distortion Intensity,ptin:_TurbulenceDistortionIntensity,varname:node_5316,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:6;n:type:ShaderForge.SFN_Set,id:3585,x:32575,y:33406,varname:Waves,prsc:2|IN-7594-OUT;n:type:ShaderForge.SFN_Multiply,id:7689,x:30097,y:31468,varname:node_7689,prsc:2|A-6256-OUT,B-2029-OUT;n:type:ShaderForge.SFN_Slider,id:2029,x:29587,y:31537,ptovrint:False,ptlb:Wave Distortion Intensity,ptin:_WaveDistortionIntensity,varname:node_2029,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6,max:4;n:type:ShaderForge.SFN_Get,id:6256,x:29715,y:31418,varname:node_6256,prsc:2|IN-3585-OUT;n:type:ShaderForge.SFN_Add,id:9806,x:30407,y:31705,varname:node_9806,prsc:2|A-7689-OUT,B-4126-OUT;n:type:ShaderForge.SFN_Set,id:3723,x:30616,y:31604,varname:Turbulence,prsc:2|IN-9806-OUT;n:type:ShaderForge.SFN_Tex2d,id:2054,x:31376,y:31266,ptovrint:False,ptlb:ReflectionTex,ptin:_ReflectionTex,varname:node_2054,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-5637-OUT;n:type:ShaderForge.SFN_Multiply,id:2978,x:31623,y:31495,varname:node_2978,prsc:2|A-2054-RGB,B-442-OUT;n:type:ShaderForge.SFN_Slider,id:442,x:31219,y:31447,ptovrint:False,ptlb:ReflectionsIntensity,ptin:_ReflectionsIntensity,varname:node_442,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_SwitchProperty,id:8497,x:31961,y:31511,ptovrint:False,ptlb:Realtime Reflections,ptin:_RealtimeReflections,varname:node_8497,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-3439-OUT,B-2978-OUT;n:type:ShaderForge.SFN_Vector1,id:3439,x:31623,y:31422,varname:node_3439,prsc:2,v1:0;n:type:ShaderForge.SFN_Blend,id:7657,x:32377,y:31823,varname:node_7657,prsc:2,blmd:8,clmp:True|SRC-8497-OUT,DST-9479-OUT;n:type:ShaderForge.SFN_LightColor,id:2175,x:32753,y:32594,varname:node_2175,prsc:2;n:type:ShaderForge.SFN_Lerp,id:7652,x:32985,y:32578,varname:node_7652,prsc:2|A-4269-OUT,B-2175-RGB,T-847-OUT;n:type:ShaderForge.SFN_Vector1,id:4269,x:32744,y:32531,varname:node_4269,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:847,x:32646,y:32780,ptovrint:False,ptlb:LightColorIntensity,ptin:_LightColorIntensity,varname:node_847,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7577848,max:1;n:type:ShaderForge.SFN_Multiply,id:557,x:33170,y:32485,varname:node_557,prsc:2|A-9052-OUT,B-7652-OUT;n:type:ShaderForge.SFN_ScreenPos,id:7915,x:30467,y:31118,varname:node_7915,prsc:2,sctp:2;n:type:ShaderForge.SFN_Lerp,id:5637,x:31118,y:31244,varname:node_5637,prsc:2|A-7915-UVOUT,B-2852-OUT,T-9806-OUT;n:type:ShaderForge.SFN_Add,id:3569,x:30629,y:31228,varname:node_3569,prsc:2|A-7915-U,B-3529-OUT;n:type:ShaderForge.SFN_Add,id:1653,x:30635,y:31357,varname:node_1653,prsc:2|A-7915-V,B-3529-OUT;n:type:ShaderForge.SFN_Vector1,id:3529,x:30414,y:31343,varname:node_3529,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Append,id:2852,x:30820,y:31271,varname:node_2852,prsc:2|A-3569-OUT,B-1653-OUT;n:type:ShaderForge.SFN_LightVector,id:8626,x:34225,y:32117,varname:node_8626,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:2851,x:34225,y:32239,varname:node_2851,prsc:2;n:type:ShaderForge.SFN_Dot,id:2191,x:34445,y:32210,varname:node_2191,prsc:2,dt:0|A-8626-OUT,B-2851-OUT;n:type:ShaderForge.SFN_Power,id:9622,x:34654,y:32303,varname:node_9622,prsc:2|VAL-2191-OUT,EXP-9470-OUT;n:type:ShaderForge.SFN_Slider,id:4133,x:33892,y:32370,ptovrint:False,ptlb:Specular Exponent,ptin:_SpecularExponent,varname:node_4133,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.189066,max:1;n:type:ShaderForge.SFN_RemapRange,id:3748,x:34225,y:32370,varname:node_3748,prsc:2,frmn:0,frmx:1,tomn:5,tomx:20|IN-4133-OUT;n:type:ShaderForge.SFN_Exp,id:9470,x:34445,y:32357,varname:node_9470,prsc:2,et:1|IN-3748-OUT;n:type:ShaderForge.SFN_Multiply,id:6014,x:34901,y:32303,varname:node_6014,prsc:2|A-9622-OUT,B-9266-RGB;n:type:ShaderForge.SFN_LightColor,id:9266,x:34661,y:32452,varname:node_9266,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8336,x:35118,y:32303,varname:node_8336,prsc:2|A-6014-OUT,B-494-OUT;n:type:ShaderForge.SFN_Get,id:494,x:34863,y:32488,varname:node_494,prsc:2|IN-3723-OUT;n:type:ShaderForge.SFN_Clamp01,id:1289,x:35298,y:32303,varname:node_1289,prsc:2|IN-8336-OUT;n:type:ShaderForge.SFN_Multiply,id:785,x:35521,y:32303,varname:node_785,prsc:2|A-1289-OUT,B-7405-OUT;n:type:ShaderForge.SFN_Slider,id:7405,x:35090,y:32512,ptovrint:False,ptlb:SpecularIntensity,ptin:_SpecularIntensity,varname:node_7405,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Set,id:4257,x:35508,y:32589,varname:SpecularIntensity,prsc:2|IN-7405-OUT;n:type:ShaderForge.SFN_Set,id:9162,x:35769,y:32361,varname:CustomLightning,prsc:2|IN-785-OUT;n:type:ShaderForge.SFN_Add,id:9911,x:33289,y:32706,varname:node_9911,prsc:2|A-557-OUT,B-2399-OUT;n:type:ShaderForge.SFN_Get,id:2399,x:33006,y:32805,varname:node_2399,prsc:2|IN-9162-OUT;n:type:ShaderForge.SFN_Tex2d,id:1591,x:29335,y:33436,varname:node_1591,prsc:2,tex:8322b723f17dc4a4a8a5dbddb0f787c7,ntxv:0,isnm:False|UVIN-7975-UVOUT,TEX-1033-TEX;n:type:ShaderForge.SFN_TexCoord,id:3484,x:28691,y:33389,varname:node_3484,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:430,x:28908,y:33420,varname:node_430,prsc:2|A-3484-UVOUT,B-5780-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5780,x:28691,y:33554,ptovrint:False,ptlb:NormalsScale,ptin:_NormalsScale,varname:node_5780,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Panner,id:7975,x:29069,y:33420,varname:node_7975,prsc:2,spu:0.01,spv:0.01|UVIN-430-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2770,x:29565,y:33486,varname:node_2770,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-1591-RGB;n:type:ShaderForge.SFN_Multiply,id:6358,x:29912,y:33560,varname:node_6358,prsc:2|A-2770-OUT,B-2895-OUT;n:type:ShaderForge.SFN_Get,id:2468,x:29367,y:33721,varname:node_2468,prsc:2|IN-4257-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:2895,x:29744,y:33693,ptovrint:False,ptlb:isSpecularNormalIntensity,ptin:_isSpecularNormalIntensity,varname:node_2895,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-4160-OUT,B-2468-OUT;n:type:ShaderForge.SFN_Slider,id:4160,x:29279,y:33816,ptovrint:False,ptlb:NormalsIntensity,ptin:_NormalsIntensity,varname:node_4160,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:9689,x:30135,y:33559,varname:node_9689,prsc:2|A-6358-OUT,B-9707-OUT;n:type:ShaderForge.SFN_Vector1,id:9707,x:29903,y:33720,varname:node_9707,prsc:2,v1:1;n:type:ShaderForge.SFN_SwitchProperty,id:3300,x:30370,y:33538,ptovrint:False,ptlb:Normals,ptin:_Normals,varname:node_3300,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-4233-OUT,B-9689-OUT;n:type:ShaderForge.SFN_Vector3,id:4233,x:30135,y:33445,varname:node_4233,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Set,id:309,x:30548,y:33582,varname:Normals,prsc:2|IN-3300-OUT;n:type:ShaderForge.SFN_Get,id:7153,x:33413,y:32646,varname:node_7153,prsc:2|IN-309-OUT;n:type:ShaderForge.SFN_Add,id:472,x:32146,y:32596,varname:node_472,prsc:2|A-1353-OUT,B-8635-OUT;n:type:ShaderForge.SFN_Set,id:3994,x:32328,y:32757,varname:FoamMask,prsc:2|IN-472-OUT;n:type:ShaderForge.SFN_Add,id:1106,x:33116,y:33012,varname:node_1106,prsc:2|A-9793-OUT,B-2775-OUT,C-5796-OUT;n:type:ShaderForge.SFN_Get,id:9793,x:32837,y:32950,varname:node_9793,prsc:2|IN-3994-OUT;n:type:ShaderForge.SFN_Slider,id:2775,x:32714,y:33022,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_2775,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9519126,max:1;n:type:ShaderForge.SFN_ValueProperty,id:1409,x:32714,y:33119,ptovrint:False,ptlb:DepthOpacity,ptin:_DepthOpacity,varname:node_1409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_DepthBlend,id:5796,x:32906,y:33119,varname:node_5796,prsc:2|DIST-1409-OUT;n:type:ShaderForge.SFN_Clamp01,id:2181,x:33283,y:33012,varname:node_2181,prsc:2|IN-1106-OUT;n:type:ShaderForge.SFN_Get,id:9901,x:33000,y:33646,varname:node_9901,prsc:2|IN-3723-OUT;n:type:ShaderForge.SFN_TexCoord,id:7093,x:33000,y:33732,varname:node_7093,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:6735,x:33227,y:33691,varname:node_6735,prsc:2|A-9901-OUT,B-7093-UVOUT;n:type:ShaderForge.SFN_Multiply,id:1901,x:33483,y:33629,varname:node_1901,prsc:2|A-366-OUT,B-6735-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3069,x:33111,y:33551,ptovrint:False,ptlb:RefractionIntensity,ptin:_RefractionIntensity,varname:node_3069,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:9104,x:33111,y:33481,varname:node_9104,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Multiply,id:366,x:33302,y:33517,varname:node_366,prsc:2|A-9104-OUT,B-3069-OUT;n:type:ShaderForge.SFN_Lerp,id:6166,x:34037,y:33676,varname:node_6166,prsc:2|A-1901-OUT,B-7085-OUT,T-7374-OUT;n:type:ShaderForge.SFN_LightColor,id:1629,x:33551,y:33761,varname:node_1629,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:3981,x:33551,y:33893,varname:node_3981,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7085,x:33762,y:33735,varname:node_7085,prsc:2|A-1629-RGB,B-3981-OUT;n:type:ShaderForge.SFN_OneMinus,id:7374,x:33762,y:33878,varname:node_7374,prsc:2|IN-3981-OUT;n:type:ShaderForge.SFN_Lerp,id:2363,x:34257,y:33523,varname:node_2363,prsc:2|A-9911-OUT,B-6166-OUT,T-1877-OUT;n:type:ShaderForge.SFN_Vector1,id:1877,x:34084,y:33821,varname:node_1877,prsc:2,v1:1;n:type:ShaderForge.SFN_SwitchProperty,id:6604,x:34464,y:33482,ptovrint:False,ptlb:Lights,ptin:_Lights,varname:node_6604,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-1326-OUT,B-2363-OUT;n:type:ShaderForge.SFN_Vector1,id:1326,x:34234,y:33435,varname:node_1326,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:2381,x:33469,y:33312,ptovrint:False,ptlb:Tesselation,ptin:_Tesselation,varname:node_2381,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:5;proporder:2381-7241-9596-5666-3572-2887-4409-3355-8049-2975-5136-6437-9655-315-6346-4845-289-3159-7781-4000-2487-7355-442-8497-847-9979-5316-2029-4133-7405-3300-4160-5780-2895-2775-1409-1033-2054-2583-3069-6604;pass:END;sub:END;*/

Shader "VaxKun/WaterShaderTesselation" {
    Properties {
        _Tesselation ("Tesselation", Range(1, 5)) = 1
        _DepthColor0 ("DepthColor0", Color) = (0.2566305,0.745283,0.7131348,1)
        _DepthColor1 ("DepthColor1", Color) = (0.2862745,0.4470589,0.7176471,1)
        _DepthColor2 ("DepthColor2", Color) = (0.1793343,0.2083115,0.4352941,1)
        _ColorPosition0 ("ColorPosition0", Float ) = 1
        _ColorPosition1 ("ColorPosition1", Float ) = 1
        _FresnelColor ("FresnelColor", Color) = (0.4861605,0.8962264,0.8699822,1)
        _FresnelExponent ("FresnelExponent", Range(0, 10)) = 8.441893
        [MaterialToggle] _VertexOffset ("VertexOffset", Float ) = 0
        _WavesAmplitude ("WavesAmplitude", Range(0, 10)) = 10
        _WavesIntensity ("WavesIntensity", Float ) = 1
        _WavesSpeed ("Waves Speed", Float ) = 1
        [MaterialToggle] _MainFoamPower ("MainFoamPower", Float ) = 0
        _FoamColor ("FoamColor", Color) = (1,1,1,1)
        _MainFoamDistance ("Main Foam Distance", Range(0, 10)) = 7.420634
        _MainFoamOpacity ("MainFoamOpacity", Range(0, 1)) = 0.9249998
        _MainFoamScale ("Main FoamScale", Float ) = 5
        _MainFoamSpeed ("Main FoamSpeed", Float ) = 0.2
        _SecondaryFoamIntensity ("SecondaryFoamIntensity", Range(0, 1)) = 0.3
        _SecondaryFoamDistance ("SecondaryFoamDistance", Range(0, 10)) = 2
        _SecondaryFoamScale ("SecondaryFoamScale", Float ) = 5
        _SecondaryFoamSpeed ("SecondaryFoamSpeed", Float ) = 0.2
        _ReflectionsIntensity ("ReflectionsIntensity", Range(0, 3)) = 1
        [MaterialToggle] _RealtimeReflections ("Realtime Reflections", Float ) = 0
        _LightColorIntensity ("LightColorIntensity", Range(0, 1)) = 0.7577848
        _TurbulenceScale ("TurbulenceScale", Float ) = 1
        _TurbulenceDistortionIntensity ("Turbulence Distortion Intensity", Range(0, 6)) = 0.8
        _WaveDistortionIntensity ("Wave Distortion Intensity", Range(0, 4)) = 0.6
        _SpecularExponent ("Specular Exponent", Range(0, 1)) = 0.189066
        _SpecularIntensity ("SpecularIntensity", Range(0, 1)) = 1
        [MaterialToggle] _Normals ("Normals", Float ) = 0
        _NormalsIntensity ("NormalsIntensity", Range(0, 1)) = 0
        _NormalsScale ("NormalsScale", Float ) = 1
        [MaterialToggle] _isSpecularNormalIntensity ("isSpecularNormalIntensity", Float ) = 1
        _Opacity ("Opacity", Range(0, 1)) = 0.9519126
        _DepthOpacity ("DepthOpacity", Float ) = 5
        _WavesNormal ("WavesNormal", 2D) = "bump" {}
        _ReflectionTex ("ReflectionTex", 2D) = "white" {}
        _FoamTexture ("FoamTexture", 2D) = "white" {}
        _RefractionIntensity ("RefractionIntensity", Float ) = 1
        [MaterialToggle] _Lights ("Lights", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ "Refraction" }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D Refraction;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _DepthColor0;
            uniform float4 _DepthColor1;
            uniform float4 _DepthColor2;
            uniform float _ColorPosition0;
            uniform float _ColorPosition1;
            uniform float4 _FresnelColor;
            uniform float _FresnelExponent;
            uniform sampler2D _WavesNormal; uniform float4 _WavesNormal_ST;
            uniform float _WavesAmplitude;
            uniform float _WavesSpeed;
            uniform float _WavesIntensity;
            uniform fixed _VertexOffset;
            uniform float _MainFoamOpacity;
            uniform float4 _FoamColor;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform float _MainFoamDistance;
            uniform float _MainFoamScale;
            uniform float _MainFoamSpeed;
            uniform fixed _MainFoamPower;
            uniform float _SecondaryFoamIntensity;
            uniform float _SecondaryFoamDistance;
            uniform float _SecondaryFoamScale;
            uniform float _SecondaryFoamSpeed;
            uniform float _TurbulenceScale;
            uniform float _TurbulenceDistortionIntensity;
            uniform float _WaveDistortionIntensity;
            uniform sampler2D _ReflectionTex; uniform float4 _ReflectionTex_ST;
            uniform float _ReflectionsIntensity;
            uniform fixed _RealtimeReflections;
            uniform float _LightColorIntensity;
            uniform float _SpecularExponent;
            uniform float _SpecularIntensity;
            uniform float _NormalsScale;
            uniform fixed _isSpecularNormalIntensity;
            uniform float _NormalsIntensity;
            uniform fixed _Normals;
            uniform float _Opacity;
            uniform float _DepthOpacity;
            uniform float _RefractionIntensity;
            uniform fixed _Lights;
            uniform float _Tesselation;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_3850 = _Time;
                float3 node_9666 = UnpackNormal(tex2Dlod(_WavesNormal,float4(TRANSFORM_TEX(o.uv0, _WavesNormal),0.0,0)));
                float node_2235 = sin(((node_3850.g*_WavesSpeed)-(node_9666.b*(_WavesAmplitude*30.0))));
                float node_7594 = (node_2235*_WavesIntensity);
                v.vertex.xyz += lerp( 0.0, (v.normal*node_7594), _VertexOffset );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_5111 = _Time;
                float2 node_7975 = ((i.uv0*_NormalsScale)+node_5111.g*float2(0.01,0.01));
                float3 node_1591 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(node_7975, _WavesNormal)));
                float SpecularIntensity = _SpecularIntensity;
                float3 Normals = lerp( float3(0,0,1), float3((node_1591.rgb.rg*lerp( _NormalsIntensity, SpecularIntensity, _isSpecularNormalIntensity )),1.0), _Normals );
                float3 normalLocal = Normals;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float4 node_3850 = _Time;
                float3 node_9666 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(i.uv0, _WavesNormal)));
                float node_2235 = sin(((node_3850.g*_WavesSpeed)-(node_9666.b*(_WavesAmplitude*30.0))));
                float node_7594 = (node_2235*_WavesIntensity);
                float Waves = node_7594;
                float2 node_6326 = ((i.uv0*_TurbulenceScale)+node_5111.g*float2(0.01,0.01));
                float3 node_6108 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(node_6326, _WavesNormal)));
                float node_9806 = ((Waves*_WaveDistortionIntensity)+(node_6108.g*_TurbulenceDistortionIntensity));
                float Turbulence = node_9806;
                float2 node_1901 = ((0.01*_RefractionIntensity)*(Turbulence*i.uv0));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + node_1901;
                float4 sceneColor = tex2D(Refraction, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
////// Emissive:
                float node_3529 = 0.01;
                float2 node_5637 = lerp(sceneUVs.rg,float2((sceneUVs.r+node_3529),(sceneUVs.g+node_3529)),node_9806);
                float4 _ReflectionTex_var = tex2D(_ReflectionTex,TRANSFORM_TEX(node_5637, _ReflectionTex));
                float4 node_446 = _Time;
                float2 node_3784 = ((_MainFoamSpeed*node_446.g)+(i.uv0*_MainFoamScale));
                float4 node_276 = tex2D(_FoamTexture,TRANSFORM_TEX(node_3784, _FoamTexture));
                float node_6120 = saturate((sceneZ-partZ)/((node_2235*0.1+0.2)*(node_276.r*_MainFoamDistance)));
                float node_1353 = ((1.0 - lerp( node_6120, saturate(pow(node_6120,15.0)), _MainFoamPower ))*_MainFoamOpacity);
                float4 node_4230 = _Time;
                float2 node_6661 = ((_SecondaryFoamSpeed*node_4230.g)+(i.uv0*_SecondaryFoamScale));
                float4 node_3520 = tex2D(_FoamTexture,TRANSFORM_TEX(node_6661, _FoamTexture));
                float node_8635 = ((1.0 - saturate((sceneZ-partZ)/_SecondaryFoamDistance))*(node_3520.r*_SecondaryFoamIntensity));
                float node_4269 = 1.0;
                float3 CustomLightning = (saturate(((pow(dot(lightDirection,viewReflectDirection),exp2((_SpecularExponent*15.0+5.0)))*_LightColor0.rgb)*Turbulence))*_SpecularIntensity);
                float3 node_9911 = (((saturate((lerp( 0.0, (_ReflectionTex_var.rgb*_ReflectionsIntensity), _RealtimeReflections )+lerp(lerp(_DepthColor0.rgb,lerp(_DepthColor1.rgb,_DepthColor2.rgb,saturate((sceneZ-partZ)/(_ColorPosition0+_ColorPosition1))),saturate((sceneZ-partZ)/_ColorPosition0)),_FresnelColor.rgb,pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent))))+(_FoamColor.rgb*node_1353)+(_FoamColor.rgb*node_8635))*lerp(float3(node_4269,node_4269,node_4269),_LightColor0.rgb,_LightColorIntensity))+CustomLightning);
                float3 emissive = node_9911;
                float3 finalColor = emissive + lerp( 0.0, lerp(node_9911,lerp(float3(node_1901,0.0),(_LightColor0.rgb*attenuation),(1.0 - attenuation)),1.0), _Lights );
                float FoamMask = (node_1353+node_8635);
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,saturate((FoamMask+_Opacity+saturate((sceneZ-partZ)/_DepthOpacity)))),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D Refraction;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _DepthColor0;
            uniform float4 _DepthColor1;
            uniform float4 _DepthColor2;
            uniform float _ColorPosition0;
            uniform float _ColorPosition1;
            uniform float4 _FresnelColor;
            uniform float _FresnelExponent;
            uniform sampler2D _WavesNormal; uniform float4 _WavesNormal_ST;
            uniform float _WavesAmplitude;
            uniform float _WavesSpeed;
            uniform float _WavesIntensity;
            uniform fixed _VertexOffset;
            uniform float _MainFoamOpacity;
            uniform float4 _FoamColor;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform float _MainFoamDistance;
            uniform float _MainFoamScale;
            uniform float _MainFoamSpeed;
            uniform fixed _MainFoamPower;
            uniform float _SecondaryFoamIntensity;
            uniform float _SecondaryFoamDistance;
            uniform float _SecondaryFoamScale;
            uniform float _SecondaryFoamSpeed;
            uniform float _TurbulenceScale;
            uniform float _TurbulenceDistortionIntensity;
            uniform float _WaveDistortionIntensity;
            uniform sampler2D _ReflectionTex; uniform float4 _ReflectionTex_ST;
            uniform float _ReflectionsIntensity;
            uniform fixed _RealtimeReflections;
            uniform float _LightColorIntensity;
            uniform float _SpecularExponent;
            uniform float _SpecularIntensity;
            uniform float _NormalsScale;
            uniform fixed _isSpecularNormalIntensity;
            uniform float _NormalsIntensity;
            uniform fixed _Normals;
            uniform float _Opacity;
            uniform float _DepthOpacity;
            uniform float _RefractionIntensity;
            uniform fixed _Lights;
            uniform float _Tesselation;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_3850 = _Time;
                float3 node_9666 = UnpackNormal(tex2Dlod(_WavesNormal,float4(TRANSFORM_TEX(o.uv0, _WavesNormal),0.0,0)));
                float node_2235 = sin(((node_3850.g*_WavesSpeed)-(node_9666.b*(_WavesAmplitude*30.0))));
                float node_7594 = (node_2235*_WavesIntensity);
                v.vertex.xyz += lerp( 0.0, (v.normal*node_7594), _VertexOffset );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_6144 = _Time;
                float2 node_7975 = ((i.uv0*_NormalsScale)+node_6144.g*float2(0.01,0.01));
                float3 node_1591 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(node_7975, _WavesNormal)));
                float SpecularIntensity = _SpecularIntensity;
                float3 Normals = lerp( float3(0,0,1), float3((node_1591.rgb.rg*lerp( _NormalsIntensity, SpecularIntensity, _isSpecularNormalIntensity )),1.0), _Normals );
                float3 normalLocal = Normals;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float4 node_3850 = _Time;
                float3 node_9666 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(i.uv0, _WavesNormal)));
                float node_2235 = sin(((node_3850.g*_WavesSpeed)-(node_9666.b*(_WavesAmplitude*30.0))));
                float node_7594 = (node_2235*_WavesIntensity);
                float Waves = node_7594;
                float2 node_6326 = ((i.uv0*_TurbulenceScale)+node_6144.g*float2(0.01,0.01));
                float3 node_6108 = UnpackNormal(tex2D(_WavesNormal,TRANSFORM_TEX(node_6326, _WavesNormal)));
                float node_9806 = ((Waves*_WaveDistortionIntensity)+(node_6108.g*_TurbulenceDistortionIntensity));
                float Turbulence = node_9806;
                float2 node_1901 = ((0.01*_RefractionIntensity)*(Turbulence*i.uv0));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + node_1901;
                float4 sceneColor = tex2D(Refraction, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                UNITY_LIGHT_ATTENUATION(attenuation,i, i.posWorld.xyz);
                float node_3529 = 0.01;
                float2 node_5637 = lerp(sceneUVs.rg,float2((sceneUVs.r+node_3529),(sceneUVs.g+node_3529)),node_9806);
                float4 _ReflectionTex_var = tex2D(_ReflectionTex,TRANSFORM_TEX(node_5637, _ReflectionTex));
                float4 node_446 = _Time;
                float2 node_3784 = ((_MainFoamSpeed*node_446.g)+(i.uv0*_MainFoamScale));
                float4 node_276 = tex2D(_FoamTexture,TRANSFORM_TEX(node_3784, _FoamTexture));
                float node_6120 = saturate((sceneZ-partZ)/((node_2235*0.1+0.2)*(node_276.r*_MainFoamDistance)));
                float node_1353 = ((1.0 - lerp( node_6120, saturate(pow(node_6120,15.0)), _MainFoamPower ))*_MainFoamOpacity);
                float4 node_4230 = _Time;
                float2 node_6661 = ((_SecondaryFoamSpeed*node_4230.g)+(i.uv0*_SecondaryFoamScale));
                float4 node_3520 = tex2D(_FoamTexture,TRANSFORM_TEX(node_6661, _FoamTexture));
                float node_8635 = ((1.0 - saturate((sceneZ-partZ)/_SecondaryFoamDistance))*(node_3520.r*_SecondaryFoamIntensity));
                float node_4269 = 1.0;
                float3 CustomLightning = (saturate(((pow(dot(lightDirection,viewReflectDirection),exp2((_SpecularExponent*15.0+5.0)))*_LightColor0.rgb)*Turbulence))*_SpecularIntensity);
                float3 node_9911 = (((saturate((lerp( 0.0, (_ReflectionTex_var.rgb*_ReflectionsIntensity), _RealtimeReflections )+lerp(lerp(_DepthColor0.rgb,lerp(_DepthColor1.rgb,_DepthColor2.rgb,saturate((sceneZ-partZ)/(_ColorPosition0+_ColorPosition1))),saturate((sceneZ-partZ)/_ColorPosition0)),_FresnelColor.rgb,pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent))))+(_FoamColor.rgb*node_1353)+(_FoamColor.rgb*node_8635))*lerp(float3(node_4269,node_4269,node_4269),_LightColor0.rgb,_LightColorIntensity))+CustomLightning);
                float3 finalColor = lerp( 0.0, lerp(node_9911,lerp(float3(node_1901,0.0),(_LightColor0.rgb*attenuation),(1.0 - attenuation)),1.0), _Lights );
                float FoamMask = (node_1353+node_8635);
                fixed4 finalRGBA = fixed4(finalColor * saturate((FoamMask+_Opacity+saturate((sceneZ-partZ)/_DepthOpacity))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    //CustomEditor "ShaderForgeMaterialInspector"
	CustomEditor "WaterShaderTesselationEditor"
}
