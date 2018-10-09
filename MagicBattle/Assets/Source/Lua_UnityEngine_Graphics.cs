using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020016DB RID: 5851
[Preserve]
public class Lua_UnityEngine_Graphics : LuaObject
{
	// Token: 0x060232DB RID: 144091 RVA: 0x00C31148 File Offset: 0x00C2F348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Graphics o = new Graphics();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232DC RID: 144092 RVA: 0x00C31190 File Offset: 0x00C2F390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMesh_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 1, out mesh);
				Matrix4x4 matrix;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				Graphics.DrawMesh(mesh, matrix, material, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int)))
			{
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 1, out mesh2);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Quaternion rotation;
				LuaObject.checkType(l, 3, out rotation);
				Material material2;
				LuaObject.checkType<Material>(l, 4, out material2);
				int layer2;
				LuaObject.checkType(l, 5, out layer2);
				Graphics.DrawMesh(mesh2, position, rotation, material2, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera)))
			{
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 1, out mesh3);
				Matrix4x4 matrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix2);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				int layer3;
				LuaObject.checkType(l, 4, out layer3);
				Camera camera;
				LuaObject.checkType<Camera>(l, 5, out camera);
				Graphics.DrawMesh(mesh3, matrix2, material3, layer3, camera);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int)))
			{
				Mesh mesh4;
				LuaObject.checkType<Mesh>(l, 1, out mesh4);
				Matrix4x4 matrix3;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix3);
				Material material4;
				LuaObject.checkType<Material>(l, 3, out material4);
				int layer4;
				LuaObject.checkType(l, 4, out layer4);
				Camera camera2;
				LuaObject.checkType<Camera>(l, 5, out camera2);
				int submeshIndex;
				LuaObject.checkType(l, 6, out submeshIndex);
				Graphics.DrawMesh(mesh4, matrix3, material4, layer4, camera2, submeshIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera)))
			{
				Mesh mesh5;
				LuaObject.checkType<Mesh>(l, 1, out mesh5);
				Vector3 position2;
				LuaObject.checkType(l, 2, out position2);
				Quaternion rotation2;
				LuaObject.checkType(l, 3, out rotation2);
				Material material5;
				LuaObject.checkType<Material>(l, 4, out material5);
				int layer5;
				LuaObject.checkType(l, 5, out layer5);
				Camera camera3;
				LuaObject.checkType<Camera>(l, 6, out camera3);
				Graphics.DrawMesh(mesh5, position2, rotation2, material5, layer5, camera3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock)))
			{
				Mesh mesh6;
				LuaObject.checkType<Mesh>(l, 1, out mesh6);
				Matrix4x4 matrix4;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix4);
				Material material6;
				LuaObject.checkType<Material>(l, 3, out material6);
				int layer6;
				LuaObject.checkType(l, 4, out layer6);
				Camera camera4;
				LuaObject.checkType<Camera>(l, 5, out camera4);
				int submeshIndex2;
				LuaObject.checkType(l, 6, out submeshIndex2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties);
				Graphics.DrawMesh(mesh6, matrix4, material6, layer6, camera4, submeshIndex2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int)))
			{
				Mesh mesh7;
				LuaObject.checkType<Mesh>(l, 1, out mesh7);
				Vector3 position3;
				LuaObject.checkType(l, 2, out position3);
				Quaternion rotation3;
				LuaObject.checkType(l, 3, out rotation3);
				Material material7;
				LuaObject.checkType<Material>(l, 4, out material7);
				int layer7;
				LuaObject.checkType(l, 5, out layer7);
				Camera camera5;
				LuaObject.checkType<Camera>(l, 6, out camera5);
				int submeshIndex3;
				LuaObject.checkType(l, 7, out submeshIndex3);
				Graphics.DrawMesh(mesh7, position3, rotation3, material7, layer7, camera5, submeshIndex3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool)))
			{
				Mesh mesh8;
				LuaObject.checkType<Mesh>(l, 1, out mesh8);
				Matrix4x4 matrix5;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix5);
				Material material8;
				LuaObject.checkType<Material>(l, 3, out material8);
				int layer8;
				LuaObject.checkType(l, 4, out layer8);
				Camera camera6;
				LuaObject.checkType<Camera>(l, 5, out camera6);
				int submeshIndex4;
				LuaObject.checkType(l, 6, out submeshIndex4);
				MaterialPropertyBlock properties2;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties2);
				bool castShadows;
				LuaObject.checkType(l, 8, out castShadows);
				Graphics.DrawMesh(mesh8, matrix5, material8, layer8, camera6, submeshIndex4, properties2, castShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock)))
			{
				Mesh mesh9;
				LuaObject.checkType<Mesh>(l, 1, out mesh9);
				Vector3 position4;
				LuaObject.checkType(l, 2, out position4);
				Quaternion rotation4;
				LuaObject.checkType(l, 3, out rotation4);
				Material material9;
				LuaObject.checkType<Material>(l, 4, out material9);
				int layer9;
				LuaObject.checkType(l, 5, out layer9);
				Camera camera7;
				LuaObject.checkType<Camera>(l, 6, out camera7);
				int submeshIndex5;
				LuaObject.checkType(l, 7, out submeshIndex5);
				MaterialPropertyBlock properties3;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties3);
				Graphics.DrawMesh(mesh9, position4, rotation4, material9, layer9, camera7, submeshIndex5, properties3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode)))
			{
				Mesh mesh10;
				LuaObject.checkType<Mesh>(l, 1, out mesh10);
				Matrix4x4 matrix6;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix6);
				Material material10;
				LuaObject.checkType<Material>(l, 3, out material10);
				int layer10;
				LuaObject.checkType(l, 4, out layer10);
				Camera camera8;
				LuaObject.checkType<Camera>(l, 5, out camera8);
				int submeshIndex6;
				LuaObject.checkType(l, 6, out submeshIndex6);
				MaterialPropertyBlock properties4;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties4);
				ShadowCastingMode castShadows2;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows2);
				Graphics.DrawMesh(mesh10, matrix6, material10, layer10, camera8, submeshIndex6, properties4, castShadows2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool), typeof(bool)))
			{
				Mesh mesh11;
				LuaObject.checkType<Mesh>(l, 1, out mesh11);
				Matrix4x4 matrix7;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix7);
				Material material11;
				LuaObject.checkType<Material>(l, 3, out material11);
				int layer11;
				LuaObject.checkType(l, 4, out layer11);
				Camera camera9;
				LuaObject.checkType<Camera>(l, 5, out camera9);
				int submeshIndex7;
				LuaObject.checkType(l, 6, out submeshIndex7);
				MaterialPropertyBlock properties5;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties5);
				bool castShadows3;
				LuaObject.checkType(l, 8, out castShadows3);
				bool receiveShadows;
				LuaObject.checkType(l, 9, out receiveShadows);
				Graphics.DrawMesh(mesh11, matrix7, material11, layer11, camera9, submeshIndex7, properties5, castShadows3, receiveShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool)))
			{
				Mesh mesh12;
				LuaObject.checkType<Mesh>(l, 1, out mesh12);
				Vector3 position5;
				LuaObject.checkType(l, 2, out position5);
				Quaternion rotation5;
				LuaObject.checkType(l, 3, out rotation5);
				Material material12;
				LuaObject.checkType<Material>(l, 4, out material12);
				int layer12;
				LuaObject.checkType(l, 5, out layer12);
				Camera camera10;
				LuaObject.checkType<Camera>(l, 6, out camera10);
				int submeshIndex8;
				LuaObject.checkType(l, 7, out submeshIndex8);
				MaterialPropertyBlock properties6;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties6);
				bool castShadows4;
				LuaObject.checkType(l, 9, out castShadows4);
				Graphics.DrawMesh(mesh12, position5, rotation5, material12, layer12, camera10, submeshIndex8, properties6, castShadows4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool)))
			{
				Mesh mesh13;
				LuaObject.checkType<Mesh>(l, 1, out mesh13);
				Matrix4x4 matrix8;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix8);
				Material material13;
				LuaObject.checkType<Material>(l, 3, out material13);
				int layer13;
				LuaObject.checkType(l, 4, out layer13);
				Camera camera11;
				LuaObject.checkType<Camera>(l, 5, out camera11);
				int submeshIndex9;
				LuaObject.checkType(l, 6, out submeshIndex9);
				MaterialPropertyBlock properties7;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties7);
				ShadowCastingMode castShadows5;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows5);
				bool receiveShadows2;
				LuaObject.checkType(l, 9, out receiveShadows2);
				Graphics.DrawMesh(mesh13, matrix8, material13, layer13, camera11, submeshIndex9, properties7, castShadows5, receiveShadows2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode)))
			{
				Mesh mesh14;
				LuaObject.checkType<Mesh>(l, 1, out mesh14);
				Vector3 position6;
				LuaObject.checkType(l, 2, out position6);
				Quaternion rotation6;
				LuaObject.checkType(l, 3, out rotation6);
				Material material14;
				LuaObject.checkType<Material>(l, 4, out material14);
				int layer14;
				LuaObject.checkType(l, 5, out layer14);
				Camera camera12;
				LuaObject.checkType<Camera>(l, 6, out camera12);
				int submeshIndex10;
				LuaObject.checkType(l, 7, out submeshIndex10);
				MaterialPropertyBlock properties8;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties8);
				ShadowCastingMode castShadows6;
				LuaObject.checkEnum<ShadowCastingMode>(l, 9, out castShadows6);
				Graphics.DrawMesh(mesh14, position6, rotation6, material14, layer14, camera12, submeshIndex10, properties8, castShadows6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool), typeof(bool), typeof(bool)))
			{
				Mesh mesh15;
				LuaObject.checkType<Mesh>(l, 1, out mesh15);
				Matrix4x4 matrix9;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix9);
				Material material15;
				LuaObject.checkType<Material>(l, 3, out material15);
				int layer15;
				LuaObject.checkType(l, 4, out layer15);
				Camera camera13;
				LuaObject.checkType<Camera>(l, 5, out camera13);
				int submeshIndex11;
				LuaObject.checkType(l, 6, out submeshIndex11);
				MaterialPropertyBlock properties9;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties9);
				bool castShadows7;
				LuaObject.checkType(l, 8, out castShadows7);
				bool receiveShadows3;
				LuaObject.checkType(l, 9, out receiveShadows3);
				bool useLightProbes;
				LuaObject.checkType(l, 10, out useLightProbes);
				Graphics.DrawMesh(mesh15, matrix9, material15, layer15, camera13, submeshIndex11, properties9, castShadows7, receiveShadows3, useLightProbes);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(bool), typeof(bool)))
			{
				Mesh mesh16;
				LuaObject.checkType<Mesh>(l, 1, out mesh16);
				Vector3 position7;
				LuaObject.checkType(l, 2, out position7);
				Quaternion rotation7;
				LuaObject.checkType(l, 3, out rotation7);
				Material material16;
				LuaObject.checkType<Material>(l, 4, out material16);
				int layer16;
				LuaObject.checkType(l, 5, out layer16);
				Camera camera14;
				LuaObject.checkType<Camera>(l, 6, out camera14);
				int submeshIndex12;
				LuaObject.checkType(l, 7, out submeshIndex12);
				MaterialPropertyBlock properties10;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties10);
				bool castShadows8;
				LuaObject.checkType(l, 9, out castShadows8);
				bool receiveShadows4;
				LuaObject.checkType(l, 10, out receiveShadows4);
				Graphics.DrawMesh(mesh16, position7, rotation7, material16, layer16, camera14, submeshIndex12, properties10, castShadows8, receiveShadows4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool)))
			{
				Mesh mesh17;
				LuaObject.checkType<Mesh>(l, 1, out mesh17);
				Vector3 position8;
				LuaObject.checkType(l, 2, out position8);
				Quaternion rotation8;
				LuaObject.checkType(l, 3, out rotation8);
				Material material17;
				LuaObject.checkType<Material>(l, 4, out material17);
				int layer17;
				LuaObject.checkType(l, 5, out layer17);
				Camera camera15;
				LuaObject.checkType<Camera>(l, 6, out camera15);
				int submeshIndex13;
				LuaObject.checkType(l, 7, out submeshIndex13);
				MaterialPropertyBlock properties11;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties11);
				ShadowCastingMode castShadows9;
				LuaObject.checkEnum<ShadowCastingMode>(l, 9, out castShadows9);
				bool receiveShadows5;
				LuaObject.checkType(l, 10, out receiveShadows5);
				Graphics.DrawMesh(mesh17, position8, rotation8, material17, layer17, camera15, submeshIndex13, properties11, castShadows9, receiveShadows5);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(Transform)))
			{
				Mesh mesh18;
				LuaObject.checkType<Mesh>(l, 1, out mesh18);
				Matrix4x4 matrix10;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix10);
				Material material18;
				LuaObject.checkType<Material>(l, 3, out material18);
				int layer18;
				LuaObject.checkType(l, 4, out layer18);
				Camera camera16;
				LuaObject.checkType<Camera>(l, 5, out camera16);
				int submeshIndex14;
				LuaObject.checkType(l, 6, out submeshIndex14);
				MaterialPropertyBlock properties12;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties12);
				ShadowCastingMode castShadows10;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows10);
				bool receiveShadows6;
				LuaObject.checkType(l, 9, out receiveShadows6);
				Transform probeAnchor;
				LuaObject.checkType<Transform>(l, 10, out probeAnchor);
				Graphics.DrawMesh(mesh18, matrix10, material18, layer18, camera16, submeshIndex14, properties12, castShadows10, receiveShadows6, probeAnchor);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, new Type[]
			{
				typeof(Mesh),
				typeof(Vector3),
				typeof(Quaternion),
				typeof(Material),
				typeof(int),
				typeof(Camera),
				typeof(int),
				typeof(MaterialPropertyBlock),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}))
			{
				Mesh mesh19;
				LuaObject.checkType<Mesh>(l, 1, out mesh19);
				Vector3 position9;
				LuaObject.checkType(l, 2, out position9);
				Quaternion rotation9;
				LuaObject.checkType(l, 3, out rotation9);
				Material material19;
				LuaObject.checkType<Material>(l, 4, out material19);
				int layer19;
				LuaObject.checkType(l, 5, out layer19);
				Camera camera17;
				LuaObject.checkType<Camera>(l, 6, out camera17);
				int submeshIndex15;
				LuaObject.checkType(l, 7, out submeshIndex15);
				MaterialPropertyBlock properties13;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties13);
				bool castShadows11;
				LuaObject.checkType(l, 9, out castShadows11);
				bool receiveShadows7;
				LuaObject.checkType(l, 10, out receiveShadows7);
				bool useLightProbes2;
				LuaObject.checkType(l, 11, out useLightProbes2);
				Graphics.DrawMesh(mesh19, position9, rotation9, material19, layer19, camera17, submeshIndex15, properties13, castShadows11, receiveShadows7, useLightProbes2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, new Type[]
			{
				typeof(Mesh),
				typeof(Vector3),
				typeof(Quaternion),
				typeof(Material),
				typeof(int),
				typeof(Camera),
				typeof(int),
				typeof(MaterialPropertyBlock),
				typeof(ShadowCastingMode),
				typeof(bool),
				typeof(Transform)
			}))
			{
				Mesh mesh20;
				LuaObject.checkType<Mesh>(l, 1, out mesh20);
				Vector3 position10;
				LuaObject.checkType(l, 2, out position10);
				Quaternion rotation10;
				LuaObject.checkType(l, 3, out rotation10);
				Material material20;
				LuaObject.checkType<Material>(l, 4, out material20);
				int layer20;
				LuaObject.checkType(l, 5, out layer20);
				Camera camera18;
				LuaObject.checkType<Camera>(l, 6, out camera18);
				int submeshIndex16;
				LuaObject.checkType(l, 7, out submeshIndex16);
				MaterialPropertyBlock properties14;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties14);
				ShadowCastingMode castShadows12;
				LuaObject.checkEnum<ShadowCastingMode>(l, 9, out castShadows12);
				bool receiveShadows8;
				LuaObject.checkType(l, 10, out receiveShadows8);
				Transform probeAnchor2;
				LuaObject.checkType<Transform>(l, 11, out probeAnchor2);
				Graphics.DrawMesh(mesh20, position10, rotation10, material20, layer20, camera18, submeshIndex16, properties14, castShadows12, receiveShadows8, probeAnchor2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, new Type[]
			{
				typeof(Mesh),
				typeof(Matrix4x4),
				typeof(Material),
				typeof(int),
				typeof(Camera),
				typeof(int),
				typeof(MaterialPropertyBlock),
				typeof(ShadowCastingMode),
				typeof(bool),
				typeof(Transform),
				typeof(bool)
			}))
			{
				Mesh mesh21;
				LuaObject.checkType<Mesh>(l, 1, out mesh21);
				Matrix4x4 matrix11;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix11);
				Material material21;
				LuaObject.checkType<Material>(l, 3, out material21);
				int layer21;
				LuaObject.checkType(l, 4, out layer21);
				Camera camera19;
				LuaObject.checkType<Camera>(l, 5, out camera19);
				int submeshIndex17;
				LuaObject.checkType(l, 6, out submeshIndex17);
				MaterialPropertyBlock properties15;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties15);
				ShadowCastingMode castShadows13;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows13);
				bool receiveShadows9;
				LuaObject.checkType(l, 9, out receiveShadows9);
				Transform probeAnchor3;
				LuaObject.checkType<Transform>(l, 10, out probeAnchor3);
				bool useLightProbes3;
				LuaObject.checkType(l, 11, out useLightProbes3);
				Graphics.DrawMesh(mesh21, matrix11, material21, layer21, camera19, submeshIndex17, properties15, castShadows13, receiveShadows9, probeAnchor3, useLightProbes3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 12)
			{
				Mesh mesh22;
				LuaObject.checkType<Mesh>(l, 1, out mesh22);
				Vector3 position11;
				LuaObject.checkType(l, 2, out position11);
				Quaternion rotation11;
				LuaObject.checkType(l, 3, out rotation11);
				Material material22;
				LuaObject.checkType<Material>(l, 4, out material22);
				int layer22;
				LuaObject.checkType(l, 5, out layer22);
				Camera camera20;
				LuaObject.checkType<Camera>(l, 6, out camera20);
				int submeshIndex18;
				LuaObject.checkType(l, 7, out submeshIndex18);
				MaterialPropertyBlock properties16;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties16);
				ShadowCastingMode castShadows14;
				LuaObject.checkEnum<ShadowCastingMode>(l, 9, out castShadows14);
				bool receiveShadows10;
				LuaObject.checkType(l, 10, out receiveShadows10);
				Transform probeAnchor4;
				LuaObject.checkType<Transform>(l, 11, out probeAnchor4);
				bool useLightProbes4;
				LuaObject.checkType(l, 12, out useLightProbes4);
				Graphics.DrawMesh(mesh22, position11, rotation11, material22, layer22, camera20, submeshIndex18, properties16, castShadows14, receiveShadows10, probeAnchor4, useLightProbes4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMesh to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232DD RID: 144093 RVA: 0x00C32494 File Offset: 0x00C30694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawProcedural_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				MeshTopology topology;
				LuaObject.checkEnum<MeshTopology>(l, 1, out topology);
				int vertexCount;
				LuaObject.checkType(l, 2, out vertexCount);
				Graphics.DrawProcedural(topology, vertexCount);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				MeshTopology topology2;
				LuaObject.checkEnum<MeshTopology>(l, 1, out topology2);
				int vertexCount2;
				LuaObject.checkType(l, 2, out vertexCount2);
				int instanceCount;
				LuaObject.checkType(l, 3, out instanceCount);
				Graphics.DrawProcedural(topology2, vertexCount2, instanceCount);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawProcedural to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232DE RID: 144094 RVA: 0x00C32550 File Offset: 0x00C30750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawProceduralIndirect_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				MeshTopology topology;
				LuaObject.checkEnum<MeshTopology>(l, 1, out topology);
				ComputeBuffer bufferWithArgs;
				LuaObject.checkType<ComputeBuffer>(l, 2, out bufferWithArgs);
				Graphics.DrawProceduralIndirect(topology, bufferWithArgs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				MeshTopology topology2;
				LuaObject.checkEnum<MeshTopology>(l, 1, out topology2);
				ComputeBuffer bufferWithArgs2;
				LuaObject.checkType<ComputeBuffer>(l, 2, out bufferWithArgs2);
				int argsOffset;
				LuaObject.checkType(l, 3, out argsOffset);
				Graphics.DrawProceduralIndirect(topology2, bufferWithArgs2, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawProceduralIndirect to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232DF RID: 144095 RVA: 0x00C3260C File Offset: 0x00C3080C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMeshInstanced_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[])))
			{
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 1, out mesh);
				int submeshIndex;
				LuaObject.checkType(l, 2, out submeshIndex);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				Matrix4x4[] matrices;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices);
				Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>)))
			{
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 1, out mesh2);
				int submeshIndex2;
				LuaObject.checkType(l, 2, out submeshIndex2);
				Material material2;
				LuaObject.checkType<Material>(l, 3, out material2);
				List<Matrix4x4> matrices2;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices2);
				Graphics.DrawMeshInstanced(mesh2, submeshIndex2, material2, matrices2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int)))
			{
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 1, out mesh3);
				int submeshIndex3;
				LuaObject.checkType(l, 2, out submeshIndex3);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				Matrix4x4[] matrices3;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices3);
				int count;
				LuaObject.checkType(l, 5, out count);
				Graphics.DrawMeshInstanced(mesh3, submeshIndex3, material3, matrices3, count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>), typeof(MaterialPropertyBlock)))
			{
				Mesh mesh4;
				LuaObject.checkType<Mesh>(l, 1, out mesh4);
				int submeshIndex4;
				LuaObject.checkType(l, 2, out submeshIndex4);
				Material material4;
				LuaObject.checkType<Material>(l, 3, out material4);
				List<Matrix4x4> matrices4;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices4);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 5, out properties);
				Graphics.DrawMeshInstanced(mesh4, submeshIndex4, material4, matrices4, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode)))
			{
				Mesh mesh5;
				LuaObject.checkType<Mesh>(l, 1, out mesh5);
				int submeshIndex5;
				LuaObject.checkType(l, 2, out submeshIndex5);
				Material material5;
				LuaObject.checkType<Material>(l, 3, out material5);
				List<Matrix4x4> matrices5;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices5);
				MaterialPropertyBlock properties2;
				LuaObject.checkType<MaterialPropertyBlock>(l, 5, out properties2);
				ShadowCastingMode castShadows;
				LuaObject.checkEnum<ShadowCastingMode>(l, 6, out castShadows);
				Graphics.DrawMeshInstanced(mesh5, submeshIndex5, material5, matrices5, properties2, castShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)))
			{
				Mesh mesh6;
				LuaObject.checkType<Mesh>(l, 1, out mesh6);
				int submeshIndex6;
				LuaObject.checkType(l, 2, out submeshIndex6);
				Material material6;
				LuaObject.checkType<Material>(l, 3, out material6);
				Matrix4x4[] matrices6;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices6);
				int count2;
				LuaObject.checkType(l, 5, out count2);
				MaterialPropertyBlock properties3;
				LuaObject.checkType<MaterialPropertyBlock>(l, 6, out properties3);
				Graphics.DrawMeshInstanced(mesh6, submeshIndex6, material6, matrices6, count2, properties3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool)))
			{
				Mesh mesh7;
				LuaObject.checkType<Mesh>(l, 1, out mesh7);
				int submeshIndex7;
				LuaObject.checkType(l, 2, out submeshIndex7);
				Material material7;
				LuaObject.checkType<Material>(l, 3, out material7);
				List<Matrix4x4> matrices7;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices7);
				MaterialPropertyBlock properties4;
				LuaObject.checkType<MaterialPropertyBlock>(l, 5, out properties4);
				ShadowCastingMode castShadows2;
				LuaObject.checkEnum<ShadowCastingMode>(l, 6, out castShadows2);
				bool receiveShadows;
				LuaObject.checkType(l, 7, out receiveShadows);
				Graphics.DrawMeshInstanced(mesh7, submeshIndex7, material7, matrices7, properties4, castShadows2, receiveShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode)))
			{
				Mesh mesh8;
				LuaObject.checkType<Mesh>(l, 1, out mesh8);
				int submeshIndex8;
				LuaObject.checkType(l, 2, out submeshIndex8);
				Material material8;
				LuaObject.checkType<Material>(l, 3, out material8);
				Matrix4x4[] matrices8;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices8);
				int count3;
				LuaObject.checkType(l, 5, out count3);
				MaterialPropertyBlock properties5;
				LuaObject.checkType<MaterialPropertyBlock>(l, 6, out properties5);
				ShadowCastingMode castShadows3;
				LuaObject.checkEnum<ShadowCastingMode>(l, 7, out castShadows3);
				Graphics.DrawMeshInstanced(mesh8, submeshIndex8, material8, matrices8, count3, properties5, castShadows3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool)))
			{
				Mesh mesh9;
				LuaObject.checkType<Mesh>(l, 1, out mesh9);
				int submeshIndex9;
				LuaObject.checkType(l, 2, out submeshIndex9);
				Material material9;
				LuaObject.checkType<Material>(l, 3, out material9);
				Matrix4x4[] matrices9;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices9);
				int count4;
				LuaObject.checkType(l, 5, out count4);
				MaterialPropertyBlock properties6;
				LuaObject.checkType<MaterialPropertyBlock>(l, 6, out properties6);
				ShadowCastingMode castShadows4;
				LuaObject.checkEnum<ShadowCastingMode>(l, 7, out castShadows4);
				bool receiveShadows2;
				LuaObject.checkType(l, 8, out receiveShadows2);
				Graphics.DrawMeshInstanced(mesh9, submeshIndex9, material9, matrices9, count4, properties6, castShadows4, receiveShadows2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int)))
			{
				Mesh mesh10;
				LuaObject.checkType<Mesh>(l, 1, out mesh10);
				int submeshIndex10;
				LuaObject.checkType(l, 2, out submeshIndex10);
				Material material10;
				LuaObject.checkType<Material>(l, 3, out material10);
				List<Matrix4x4> matrices10;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices10);
				MaterialPropertyBlock properties7;
				LuaObject.checkType<MaterialPropertyBlock>(l, 5, out properties7);
				ShadowCastingMode castShadows5;
				LuaObject.checkEnum<ShadowCastingMode>(l, 6, out castShadows5);
				bool receiveShadows3;
				LuaObject.checkType(l, 7, out receiveShadows3);
				int layer;
				LuaObject.checkType(l, 8, out layer);
				Graphics.DrawMeshInstanced(mesh10, submeshIndex10, material10, matrices10, properties7, castShadows5, receiveShadows3, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int)))
			{
				Mesh mesh11;
				LuaObject.checkType<Mesh>(l, 1, out mesh11);
				int submeshIndex11;
				LuaObject.checkType(l, 2, out submeshIndex11);
				Material material11;
				LuaObject.checkType<Material>(l, 3, out material11);
				Matrix4x4[] matrices11;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices11);
				int count5;
				LuaObject.checkType(l, 5, out count5);
				MaterialPropertyBlock properties8;
				LuaObject.checkType<MaterialPropertyBlock>(l, 6, out properties8);
				ShadowCastingMode castShadows6;
				LuaObject.checkEnum<ShadowCastingMode>(l, 7, out castShadows6);
				bool receiveShadows4;
				LuaObject.checkType(l, 8, out receiveShadows4);
				int layer2;
				LuaObject.checkType(l, 9, out layer2);
				Graphics.DrawMeshInstanced(mesh11, submeshIndex11, material11, matrices11, count5, properties8, castShadows6, receiveShadows4, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(int), typeof(Material), typeof(List<Matrix4x4>), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera)))
			{
				Mesh mesh12;
				LuaObject.checkType<Mesh>(l, 1, out mesh12);
				int submeshIndex12;
				LuaObject.checkType(l, 2, out submeshIndex12);
				Material material12;
				LuaObject.checkType<Material>(l, 3, out material12);
				List<Matrix4x4> matrices12;
				LuaObject.checkType<List<Matrix4x4>>(l, 4, out matrices12);
				MaterialPropertyBlock properties9;
				LuaObject.checkType<MaterialPropertyBlock>(l, 5, out properties9);
				ShadowCastingMode castShadows7;
				LuaObject.checkEnum<ShadowCastingMode>(l, 6, out castShadows7);
				bool receiveShadows5;
				LuaObject.checkType(l, 7, out receiveShadows5);
				int layer3;
				LuaObject.checkType(l, 8, out layer3);
				Camera camera;
				LuaObject.checkType<Camera>(l, 9, out camera);
				Graphics.DrawMeshInstanced(mesh12, submeshIndex12, material12, matrices12, properties9, castShadows7, receiveShadows5, layer3, camera);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				Mesh mesh13;
				LuaObject.checkType<Mesh>(l, 1, out mesh13);
				int submeshIndex13;
				LuaObject.checkType(l, 2, out submeshIndex13);
				Material material13;
				LuaObject.checkType<Material>(l, 3, out material13);
				Matrix4x4[] matrices13;
				LuaObject.checkArray<Matrix4x4>(l, 4, out matrices13);
				int count6;
				LuaObject.checkType(l, 5, out count6);
				MaterialPropertyBlock properties10;
				LuaObject.checkType<MaterialPropertyBlock>(l, 6, out properties10);
				ShadowCastingMode castShadows8;
				LuaObject.checkEnum<ShadowCastingMode>(l, 7, out castShadows8);
				bool receiveShadows6;
				LuaObject.checkType(l, 8, out receiveShadows6);
				int layer4;
				LuaObject.checkType(l, 9, out layer4);
				Camera camera2;
				LuaObject.checkType<Camera>(l, 10, out camera2);
				Graphics.DrawMeshInstanced(mesh13, submeshIndex13, material13, matrices13, count6, properties10, castShadows8, receiveShadows6, layer4, camera2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMeshInstanced to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E0 RID: 144096 RVA: 0x00C32F40 File Offset: 0x00C31140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMeshInstancedIndirect_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 1, out mesh);
				int submeshIndex;
				LuaObject.checkType(l, 2, out submeshIndex);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				Bounds bounds;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds);
				ComputeBuffer bufferWithArgs;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs);
				Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 1, out mesh2);
				int submeshIndex2;
				LuaObject.checkType(l, 2, out submeshIndex2);
				Material material2;
				LuaObject.checkType<Material>(l, 3, out material2);
				Bounds bounds2;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds2);
				ComputeBuffer bufferWithArgs2;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs2);
				int argsOffset;
				LuaObject.checkType(l, 6, out argsOffset);
				Graphics.DrawMeshInstancedIndirect(mesh2, submeshIndex2, material2, bounds2, bufferWithArgs2, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 1, out mesh3);
				int submeshIndex3;
				LuaObject.checkType(l, 2, out submeshIndex3);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				Bounds bounds3;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds3);
				ComputeBuffer bufferWithArgs3;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs3);
				int argsOffset2;
				LuaObject.checkType(l, 6, out argsOffset2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties);
				Graphics.DrawMeshInstancedIndirect(mesh3, submeshIndex3, material3, bounds3, bufferWithArgs3, argsOffset2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				Mesh mesh4;
				LuaObject.checkType<Mesh>(l, 1, out mesh4);
				int submeshIndex4;
				LuaObject.checkType(l, 2, out submeshIndex4);
				Material material4;
				LuaObject.checkType<Material>(l, 3, out material4);
				Bounds bounds4;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds4);
				ComputeBuffer bufferWithArgs4;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs4);
				int argsOffset3;
				LuaObject.checkType(l, 6, out argsOffset3);
				MaterialPropertyBlock properties2;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties2);
				ShadowCastingMode castShadows;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows);
				Graphics.DrawMeshInstancedIndirect(mesh4, submeshIndex4, material4, bounds4, bufferWithArgs4, argsOffset3, properties2, castShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 9)
			{
				Mesh mesh5;
				LuaObject.checkType<Mesh>(l, 1, out mesh5);
				int submeshIndex5;
				LuaObject.checkType(l, 2, out submeshIndex5);
				Material material5;
				LuaObject.checkType<Material>(l, 3, out material5);
				Bounds bounds5;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds5);
				ComputeBuffer bufferWithArgs5;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs5);
				int argsOffset4;
				LuaObject.checkType(l, 6, out argsOffset4);
				MaterialPropertyBlock properties3;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties3);
				ShadowCastingMode castShadows2;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows2);
				bool receiveShadows;
				LuaObject.checkType(l, 9, out receiveShadows);
				Graphics.DrawMeshInstancedIndirect(mesh5, submeshIndex5, material5, bounds5, bufferWithArgs5, argsOffset4, properties3, castShadows2, receiveShadows);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				Mesh mesh6;
				LuaObject.checkType<Mesh>(l, 1, out mesh6);
				int submeshIndex6;
				LuaObject.checkType(l, 2, out submeshIndex6);
				Material material6;
				LuaObject.checkType<Material>(l, 3, out material6);
				Bounds bounds6;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds6);
				ComputeBuffer bufferWithArgs6;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs6);
				int argsOffset5;
				LuaObject.checkType(l, 6, out argsOffset5);
				MaterialPropertyBlock properties4;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties4);
				ShadowCastingMode castShadows3;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows3);
				bool receiveShadows2;
				LuaObject.checkType(l, 9, out receiveShadows2);
				int layer;
				LuaObject.checkType(l, 10, out layer);
				Graphics.DrawMeshInstancedIndirect(mesh6, submeshIndex6, material6, bounds6, bufferWithArgs6, argsOffset5, properties4, castShadows3, receiveShadows2, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 11)
			{
				Mesh mesh7;
				LuaObject.checkType<Mesh>(l, 1, out mesh7);
				int submeshIndex7;
				LuaObject.checkType(l, 2, out submeshIndex7);
				Material material7;
				LuaObject.checkType<Material>(l, 3, out material7);
				Bounds bounds7;
				LuaObject.checkValueType<Bounds>(l, 4, out bounds7);
				ComputeBuffer bufferWithArgs7;
				LuaObject.checkType<ComputeBuffer>(l, 5, out bufferWithArgs7);
				int argsOffset6;
				LuaObject.checkType(l, 6, out argsOffset6);
				MaterialPropertyBlock properties5;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties5);
				ShadowCastingMode castShadows4;
				LuaObject.checkEnum<ShadowCastingMode>(l, 8, out castShadows4);
				bool receiveShadows3;
				LuaObject.checkType(l, 9, out receiveShadows3);
				int layer2;
				LuaObject.checkType(l, 10, out layer2);
				Camera camera;
				LuaObject.checkType<Camera>(l, 11, out camera);
				Graphics.DrawMeshInstancedIndirect(mesh7, submeshIndex7, material7, bounds7, bufferWithArgs7, argsOffset6, properties5, castShadows4, receiveShadows3, layer2, camera);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMeshInstancedIndirect to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E1 RID: 144097 RVA: 0x00C33300 File Offset: 0x00C31500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rect screenRect;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect);
				Texture texture;
				LuaObject.checkType<Texture>(l, 2, out texture);
				Graphics.DrawTexture(screenRect, texture);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Rect screenRect2;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect2);
				Texture texture2;
				LuaObject.checkType<Texture>(l, 2, out texture2);
				Material mat;
				LuaObject.checkType<Material>(l, 3, out mat);
				Graphics.DrawTexture(screenRect2, texture2, mat);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rect screenRect3;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect3);
				Texture texture3;
				LuaObject.checkType<Texture>(l, 2, out texture3);
				Material mat2;
				LuaObject.checkType<Material>(l, 3, out mat2);
				int pass;
				LuaObject.checkType(l, 4, out pass);
				Graphics.DrawTexture(screenRect3, texture3, mat2, pass);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Rect screenRect4;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect4);
				Texture texture4;
				LuaObject.checkType<Texture>(l, 2, out texture4);
				int leftBorder;
				LuaObject.checkType(l, 3, out leftBorder);
				int rightBorder;
				LuaObject.checkType(l, 4, out rightBorder);
				int topBorder;
				LuaObject.checkType(l, 5, out topBorder);
				int bottomBorder;
				LuaObject.checkType(l, 6, out bottomBorder);
				Graphics.DrawTexture(screenRect4, texture4, leftBorder, rightBorder, topBorder, bottomBorder);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int)))
			{
				Rect screenRect5;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect5);
				Texture texture5;
				LuaObject.checkType<Texture>(l, 2, out texture5);
				Rect sourceRect;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect);
				int leftBorder2;
				LuaObject.checkType(l, 4, out leftBorder2);
				int rightBorder2;
				LuaObject.checkType(l, 5, out rightBorder2);
				int topBorder2;
				LuaObject.checkType(l, 6, out topBorder2);
				int bottomBorder2;
				LuaObject.checkType(l, 7, out bottomBorder2);
				Graphics.DrawTexture(screenRect5, texture5, sourceRect, leftBorder2, rightBorder2, topBorder2, bottomBorder2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material)))
			{
				Rect screenRect6;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect6);
				Texture texture6;
				LuaObject.checkType<Texture>(l, 2, out texture6);
				int leftBorder3;
				LuaObject.checkType(l, 3, out leftBorder3);
				int rightBorder3;
				LuaObject.checkType(l, 4, out rightBorder3);
				int topBorder3;
				LuaObject.checkType(l, 5, out topBorder3);
				int bottomBorder3;
				LuaObject.checkType(l, 6, out bottomBorder3);
				Material mat3;
				LuaObject.checkType<Material>(l, 7, out mat3);
				Graphics.DrawTexture(screenRect6, texture6, leftBorder3, rightBorder3, topBorder3, bottomBorder3, mat3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)))
			{
				Rect screenRect7;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect7);
				Texture texture7;
				LuaObject.checkType<Texture>(l, 2, out texture7);
				Rect sourceRect2;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect2);
				int leftBorder4;
				LuaObject.checkType(l, 4, out leftBorder4);
				int rightBorder4;
				LuaObject.checkType(l, 5, out rightBorder4);
				int topBorder4;
				LuaObject.checkType(l, 6, out topBorder4);
				int bottomBorder4;
				LuaObject.checkType(l, 7, out bottomBorder4);
				Color color;
				LuaObject.checkType(l, 8, out color);
				Graphics.DrawTexture(screenRect7, texture7, sourceRect2, leftBorder4, rightBorder4, topBorder4, bottomBorder4, color);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material), typeof(int)))
			{
				Rect screenRect8;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect8);
				Texture texture8;
				LuaObject.checkType<Texture>(l, 2, out texture8);
				int leftBorder5;
				LuaObject.checkType(l, 3, out leftBorder5);
				int rightBorder5;
				LuaObject.checkType(l, 4, out rightBorder5);
				int topBorder5;
				LuaObject.checkType(l, 5, out topBorder5);
				int bottomBorder5;
				LuaObject.checkType(l, 6, out bottomBorder5);
				Material mat4;
				LuaObject.checkType<Material>(l, 7, out mat4);
				int pass2;
				LuaObject.checkType(l, 8, out pass2);
				Graphics.DrawTexture(screenRect8, texture8, leftBorder5, rightBorder5, topBorder5, bottomBorder5, mat4, pass2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material)))
			{
				Rect screenRect9;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect9);
				Texture texture9;
				LuaObject.checkType<Texture>(l, 2, out texture9);
				Rect sourceRect3;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect3);
				int leftBorder6;
				LuaObject.checkType(l, 4, out leftBorder6);
				int rightBorder6;
				LuaObject.checkType(l, 5, out rightBorder6);
				int topBorder6;
				LuaObject.checkType(l, 6, out topBorder6);
				int bottomBorder6;
				LuaObject.checkType(l, 7, out bottomBorder6);
				Material mat5;
				LuaObject.checkType<Material>(l, 8, out mat5);
				Graphics.DrawTexture(screenRect9, texture9, sourceRect3, leftBorder6, rightBorder6, topBorder6, bottomBorder6, mat5);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color), typeof(Material)))
			{
				Rect screenRect10;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect10);
				Texture texture10;
				LuaObject.checkType<Texture>(l, 2, out texture10);
				Rect sourceRect4;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect4);
				int leftBorder7;
				LuaObject.checkType(l, 4, out leftBorder7);
				int rightBorder7;
				LuaObject.checkType(l, 5, out rightBorder7);
				int topBorder7;
				LuaObject.checkType(l, 6, out topBorder7);
				int bottomBorder7;
				LuaObject.checkType(l, 7, out bottomBorder7);
				Color color2;
				LuaObject.checkType(l, 8, out color2);
				Material mat6;
				LuaObject.checkType<Material>(l, 9, out mat6);
				Graphics.DrawTexture(screenRect10, texture10, sourceRect4, leftBorder7, rightBorder7, topBorder7, bottomBorder7, color2, mat6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rect), typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Material), typeof(int)))
			{
				Rect screenRect11;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect11);
				Texture texture11;
				LuaObject.checkType<Texture>(l, 2, out texture11);
				Rect sourceRect5;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect5);
				int leftBorder8;
				LuaObject.checkType(l, 4, out leftBorder8);
				int rightBorder8;
				LuaObject.checkType(l, 5, out rightBorder8);
				int topBorder8;
				LuaObject.checkType(l, 6, out topBorder8);
				int bottomBorder8;
				LuaObject.checkType(l, 7, out bottomBorder8);
				Material mat7;
				LuaObject.checkType<Material>(l, 8, out mat7);
				int pass3;
				LuaObject.checkType(l, 9, out pass3);
				Graphics.DrawTexture(screenRect11, texture11, sourceRect5, leftBorder8, rightBorder8, topBorder8, bottomBorder8, mat7, pass3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				Rect screenRect12;
				LuaObject.checkValueType<Rect>(l, 1, out screenRect12);
				Texture texture12;
				LuaObject.checkType<Texture>(l, 2, out texture12);
				Rect sourceRect6;
				LuaObject.checkValueType<Rect>(l, 3, out sourceRect6);
				int leftBorder9;
				LuaObject.checkType(l, 4, out leftBorder9);
				int rightBorder9;
				LuaObject.checkType(l, 5, out rightBorder9);
				int topBorder9;
				LuaObject.checkType(l, 6, out topBorder9);
				int bottomBorder9;
				LuaObject.checkType(l, 7, out bottomBorder9);
				Color color3;
				LuaObject.checkType(l, 8, out color3);
				Material mat8;
				LuaObject.checkType<Material>(l, 9, out mat8);
				int pass4;
				LuaObject.checkType(l, 10, out pass4);
				Graphics.DrawTexture(screenRect12, texture12, sourceRect6, leftBorder9, rightBorder9, topBorder9, bottomBorder9, color3, mat8, pass4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E2 RID: 144098 RVA: 0x00C33ABC File Offset: 0x00C31CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGPUFence_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 0)
			{
				GPUFence gpufence = Graphics.CreateGPUFence();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gpufence);
				result = 2;
			}
			else if (num == 1)
			{
				SynchronisationStage stage;
				LuaObject.checkEnum<SynchronisationStage>(l, 1, out stage);
				GPUFence gpufence2 = Graphics.CreateGPUFence(stage);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gpufence2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateGPUFence to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E3 RID: 144099 RVA: 0x00C33B64 File Offset: 0x00C31D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitOnGPUFence_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				GPUFence fence;
				LuaObject.checkValueType<GPUFence>(l, 1, out fence);
				Graphics.WaitOnGPUFence(fence);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				GPUFence fence2;
				LuaObject.checkValueType<GPUFence>(l, 1, out fence2);
				SynchronisationStage stage;
				LuaObject.checkEnum<SynchronisationStage>(l, 2, out stage);
				Graphics.WaitOnGPUFence(fence2, stage);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function WaitOnGPUFence to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E4 RID: 144100 RVA: 0x00C33C08 File Offset: 0x00C31E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteCommandBuffer_s(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer buffer;
			LuaObject.checkType<CommandBuffer>(l, 1, out buffer);
			Graphics.ExecuteCommandBuffer(buffer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E5 RID: 144101 RVA: 0x00C33C54 File Offset: 0x00C31E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteCommandBufferAsync_s(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer buffer;
			LuaObject.checkType<CommandBuffer>(l, 1, out buffer);
			ComputeQueueType queueType;
			LuaObject.checkEnum<ComputeQueueType>(l, 2, out queueType);
			Graphics.ExecuteCommandBufferAsync(buffer, queueType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E6 RID: 144102 RVA: 0x00C33CAC File Offset: 0x00C31EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Blit_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(Material)))
			{
				Texture source;
				LuaObject.checkType<Texture>(l, 1, out source);
				Material mat;
				LuaObject.checkType<Material>(l, 2, out mat);
				Graphics.Blit(source, mat);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(RenderTexture)))
			{
				Texture source2;
				LuaObject.checkType<Texture>(l, 1, out source2);
				RenderTexture dest;
				LuaObject.checkType<RenderTexture>(l, 2, out dest);
				Graphics.Blit(source2, dest);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(Material), typeof(int)))
			{
				Texture source3;
				LuaObject.checkType<Texture>(l, 1, out source3);
				Material mat2;
				LuaObject.checkType<Material>(l, 2, out mat2);
				int pass;
				LuaObject.checkType(l, 3, out pass);
				Graphics.Blit(source3, mat2, pass);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(RenderTexture), typeof(Material)))
			{
				Texture source4;
				LuaObject.checkType<Texture>(l, 1, out source4);
				RenderTexture dest2;
				LuaObject.checkType<RenderTexture>(l, 2, out dest2);
				Material mat3;
				LuaObject.checkType<Material>(l, 3, out mat3);
				Graphics.Blit(source4, dest2, mat3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(RenderTexture), typeof(Vector2), typeof(Vector2)))
			{
				Texture source5;
				LuaObject.checkType<Texture>(l, 1, out source5);
				RenderTexture dest3;
				LuaObject.checkType<RenderTexture>(l, 2, out dest3);
				Vector2 scale;
				LuaObject.checkType(l, 3, out scale);
				Vector2 offset;
				LuaObject.checkType(l, 4, out offset);
				Graphics.Blit(source5, dest3, scale, offset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Texture), typeof(RenderTexture), typeof(Material), typeof(int)))
			{
				Texture source6;
				LuaObject.checkType<Texture>(l, 1, out source6);
				RenderTexture dest4;
				LuaObject.checkType<RenderTexture>(l, 2, out dest4);
				Material mat4;
				LuaObject.checkType<Material>(l, 3, out mat4);
				int pass2;
				LuaObject.checkType(l, 4, out pass2);
				Graphics.Blit(source6, dest4, mat4, pass2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Blit to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E7 RID: 144103 RVA: 0x00C33F50 File Offset: 0x00C32150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BlitMultiTap_s(IntPtr l)
	{
		int result;
		try
		{
			Texture source;
			LuaObject.checkType<Texture>(l, 1, out source);
			RenderTexture dest;
			LuaObject.checkType<RenderTexture>(l, 2, out dest);
			Material mat;
			LuaObject.checkType<Material>(l, 3, out mat);
			Vector2[] offsets;
			LuaObject.checkParams(l, 4, out offsets);
			Graphics.BlitMultiTap(source, dest, mat, offsets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E8 RID: 144104 RVA: 0x00C33FC0 File Offset: 0x00C321C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomWriteTarget_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(int), typeof(ComputeBuffer)))
			{
				int index;
				LuaObject.checkType(l, 1, out index);
				ComputeBuffer uav;
				LuaObject.checkType<ComputeBuffer>(l, 2, out uav);
				Graphics.SetRandomWriteTarget(index, uav);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(int), typeof(RenderTexture)))
			{
				int index2;
				LuaObject.checkType(l, 1, out index2);
				RenderTexture uav2;
				LuaObject.checkType<RenderTexture>(l, 2, out uav2);
				Graphics.SetRandomWriteTarget(index2, uav2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				int index3;
				LuaObject.checkType(l, 1, out index3);
				ComputeBuffer uav3;
				LuaObject.checkType<ComputeBuffer>(l, 2, out uav3);
				bool preserveCounterValue;
				LuaObject.checkType(l, 3, out preserveCounterValue);
				Graphics.SetRandomWriteTarget(index3, uav3, preserveCounterValue);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetRandomWriteTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232E9 RID: 144105 RVA: 0x00C340E4 File Offset: 0x00C322E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRandomWriteTargets_s(IntPtr l)
	{
		int result;
		try
		{
			Graphics.ClearRandomWriteTargets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232EA RID: 144106 RVA: 0x00C34124 File Offset: 0x00C32324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRenderTarget_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(RenderTexture)))
			{
				RenderTexture renderTarget;
				LuaObject.checkType<RenderTexture>(l, 1, out renderTarget);
				Graphics.SetRenderTarget(renderTarget);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderTargetSetup)))
			{
				RenderTargetSetup renderTarget2;
				LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTarget2);
				Graphics.SetRenderTarget(renderTarget2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderBuffer), typeof(RenderBuffer)))
			{
				RenderBuffer colorBuffer;
				LuaObject.checkValueType<RenderBuffer>(l, 1, out colorBuffer);
				RenderBuffer depthBuffer;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out depthBuffer);
				Graphics.SetRenderTarget(colorBuffer, depthBuffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderBuffer[]), typeof(RenderBuffer)))
			{
				RenderBuffer[] colorBuffers;
				LuaObject.checkArray<RenderBuffer>(l, 1, out colorBuffers);
				RenderBuffer depthBuffer2;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out depthBuffer2);
				Graphics.SetRenderTarget(colorBuffers, depthBuffer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderTexture), typeof(int)))
			{
				RenderTexture rt;
				LuaObject.checkType<RenderTexture>(l, 1, out rt);
				int mipLevel;
				LuaObject.checkType(l, 2, out mipLevel);
				Graphics.SetRenderTarget(rt, mipLevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderTexture), typeof(int), typeof(CubemapFace)))
			{
				RenderTexture rt2;
				LuaObject.checkType<RenderTexture>(l, 1, out rt2);
				int mipLevel2;
				LuaObject.checkType(l, 2, out mipLevel2);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face);
				Graphics.SetRenderTarget(rt2, mipLevel2, face);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderBuffer), typeof(RenderBuffer), typeof(int)))
			{
				RenderBuffer colorBuffer2;
				LuaObject.checkValueType<RenderBuffer>(l, 1, out colorBuffer2);
				RenderBuffer depthBuffer3;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out depthBuffer3);
				int mipLevel3;
				LuaObject.checkType(l, 3, out mipLevel3);
				Graphics.SetRenderTarget(colorBuffer2, depthBuffer3, mipLevel3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				RenderTexture rt3;
				LuaObject.checkType<RenderTexture>(l, 1, out rt3);
				int mipLevel4;
				LuaObject.checkType(l, 2, out mipLevel4);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face2);
				int depthSlice;
				LuaObject.checkType(l, 4, out depthSlice);
				Graphics.SetRenderTarget(rt3, mipLevel4, face2, depthSlice);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(RenderBuffer), typeof(RenderBuffer), typeof(int), typeof(CubemapFace)))
			{
				RenderBuffer colorBuffer3;
				LuaObject.checkValueType<RenderBuffer>(l, 1, out colorBuffer3);
				RenderBuffer depthBuffer4;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out depthBuffer4);
				int mipLevel5;
				LuaObject.checkType(l, 3, out mipLevel5);
				CubemapFace face3;
				LuaObject.checkEnum<CubemapFace>(l, 4, out face3);
				Graphics.SetRenderTarget(colorBuffer3, depthBuffer4, mipLevel5, face3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				RenderBuffer colorBuffer4;
				LuaObject.checkValueType<RenderBuffer>(l, 1, out colorBuffer4);
				RenderBuffer depthBuffer5;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out depthBuffer5);
				int mipLevel6;
				LuaObject.checkType(l, 3, out mipLevel6);
				CubemapFace face4;
				LuaObject.checkEnum<CubemapFace>(l, 4, out face4);
				int depthSlice2;
				LuaObject.checkType(l, 5, out depthSlice2);
				Graphics.SetRenderTarget(colorBuffer4, depthBuffer5, mipLevel6, face4, depthSlice2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetRenderTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232EB RID: 144107 RVA: 0x00C344D8 File Offset: 0x00C326D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture src;
				LuaObject.checkType<Texture>(l, 1, out src);
				Texture dst;
				LuaObject.checkType<Texture>(l, 2, out dst);
				Graphics.CopyTexture(src, dst);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Texture src2;
				LuaObject.checkType<Texture>(l, 1, out src2);
				int srcElement;
				LuaObject.checkType(l, 2, out srcElement);
				Texture dst2;
				LuaObject.checkType<Texture>(l, 3, out dst2);
				int dstElement;
				LuaObject.checkType(l, 4, out dstElement);
				Graphics.CopyTexture(src2, srcElement, dst2, dstElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Texture src3;
				LuaObject.checkType<Texture>(l, 1, out src3);
				int srcElement2;
				LuaObject.checkType(l, 2, out srcElement2);
				int srcMip;
				LuaObject.checkType(l, 3, out srcMip);
				Texture dst3;
				LuaObject.checkType<Texture>(l, 4, out dst3);
				int dstElement2;
				LuaObject.checkType(l, 5, out dstElement2);
				int dstMip;
				LuaObject.checkType(l, 6, out dstMip);
				Graphics.CopyTexture(src3, srcElement2, srcMip, dst3, dstElement2, dstMip);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 12)
			{
				Texture src4;
				LuaObject.checkType<Texture>(l, 1, out src4);
				int srcElement3;
				LuaObject.checkType(l, 2, out srcElement3);
				int srcMip2;
				LuaObject.checkType(l, 3, out srcMip2);
				int srcX;
				LuaObject.checkType(l, 4, out srcX);
				int srcY;
				LuaObject.checkType(l, 5, out srcY);
				int srcWidth;
				LuaObject.checkType(l, 6, out srcWidth);
				int srcHeight;
				LuaObject.checkType(l, 7, out srcHeight);
				Texture dst4;
				LuaObject.checkType<Texture>(l, 8, out dst4);
				int dstElement3;
				LuaObject.checkType(l, 9, out dstElement3);
				int dstMip2;
				LuaObject.checkType(l, 10, out dstMip2);
				int dstX;
				LuaObject.checkType(l, 11, out dstX);
				int dstY;
				LuaObject.checkType(l, 12, out dstY);
				Graphics.CopyTexture(src4, srcElement3, srcMip2, srcX, srcY, srcWidth, srcHeight, dst4, dstElement3, dstMip2, dstX, dstY);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CopyTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232EC RID: 144108 RVA: 0x00C346C0 File Offset: 0x00C328C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ConvertTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture src;
				LuaObject.checkType<Texture>(l, 1, out src);
				Texture dst;
				LuaObject.checkType<Texture>(l, 2, out dst);
				bool b = Graphics.ConvertTexture(src, dst);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				Texture src2;
				LuaObject.checkType<Texture>(l, 1, out src2);
				int srcElement;
				LuaObject.checkType(l, 2, out srcElement);
				Texture dst2;
				LuaObject.checkType<Texture>(l, 3, out dst2);
				int dstElement;
				LuaObject.checkType(l, 4, out dstElement);
				bool b2 = Graphics.ConvertTexture(src2, srcElement, dst2, dstElement);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ConvertTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232ED RID: 144109 RVA: 0x00C347A0 File Offset: 0x00C329A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMeshNow_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 1, out mesh);
				Matrix4x4 matrix;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix);
				Graphics.DrawMeshNow(mesh, matrix);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Matrix4x4), typeof(int)))
			{
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 1, out mesh2);
				Matrix4x4 matrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix2);
				int materialIndex;
				LuaObject.checkType(l, 3, out materialIndex);
				Graphics.DrawMeshNow(mesh2, matrix2, materialIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Mesh), typeof(Vector3), typeof(Quaternion)))
			{
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 1, out mesh3);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Quaternion rotation;
				LuaObject.checkType(l, 3, out rotation);
				Graphics.DrawMeshNow(mesh3, position, rotation);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Mesh mesh4;
				LuaObject.checkType<Mesh>(l, 1, out mesh4);
				Vector3 position2;
				LuaObject.checkType(l, 2, out position2);
				Quaternion rotation2;
				LuaObject.checkType(l, 3, out rotation2);
				int materialIndex2;
				LuaObject.checkType(l, 4, out materialIndex2);
				Graphics.DrawMeshNow(mesh4, position2, rotation2, materialIndex2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMeshNow to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232EE RID: 144110 RVA: 0x00C34938 File Offset: 0x00C32B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeColorBuffer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Graphics.activeColorBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232EF RID: 144111 RVA: 0x00C34984 File Offset: 0x00C32B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeDepthBuffer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Graphics.activeDepthBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F0 RID: 144112 RVA: 0x00C349D0 File Offset: 0x00C32BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeTier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Graphics.activeTier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F1 RID: 144113 RVA: 0x00C34A18 File Offset: 0x00C32C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_activeTier(IntPtr l)
	{
		int result;
		try
		{
			GraphicsTier activeTier;
			LuaObject.checkEnum<GraphicsTier>(l, 2, out activeTier);
			Graphics.activeTier = activeTier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F2 RID: 144114 RVA: 0x00C34A64 File Offset: 0x00C32C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeColorGamut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Graphics.activeColorGamut);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F3 RID: 144115 RVA: 0x00C34AAC File Offset: 0x00C32CAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Graphics");
		if (Lua_UnityEngine_Graphics.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawMesh_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache0);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawProcedural_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache1);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawProceduralIndirect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache2);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawMeshInstanced_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache3);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawMeshInstancedIndirect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache4);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache5);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Graphics.CreateGPUFence_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache6);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Graphics.WaitOnGPUFence_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache7);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Graphics.ExecuteCommandBuffer_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache8);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Graphics.ExecuteCommandBufferAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache9);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Graphics.Blit_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheA);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Graphics.BlitMultiTap_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheB);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Graphics.SetRandomWriteTarget_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheC);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Graphics.ClearRandomWriteTargets_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheD);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Graphics.SetRenderTarget_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheE);
		if (Lua_UnityEngine_Graphics.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Graphics.CopyTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cacheF);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Graphics.ConvertTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache10);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Graphics.DrawMeshNow_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Graphics.<>f__mg$cache11);
		string name = "activeColorBuffer";
		if (Lua_UnityEngine_Graphics.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Graphics.get_activeColorBuffer);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Graphics.<>f__mg$cache12, null, false);
		string name2 = "activeDepthBuffer";
		if (Lua_UnityEngine_Graphics.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Graphics.get_activeDepthBuffer);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Graphics.<>f__mg$cache13, null, false);
		string name3 = "activeTier";
		if (Lua_UnityEngine_Graphics.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Graphics.get_activeTier);
		}
		LuaCSFunction get = Lua_UnityEngine_Graphics.<>f__mg$cache14;
		if (Lua_UnityEngine_Graphics.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Graphics.set_activeTier);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_Graphics.<>f__mg$cache15, false);
		string name4 = "activeColorGamut";
		if (Lua_UnityEngine_Graphics.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Graphics.get_activeColorGamut);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Graphics.<>f__mg$cache16, null, false);
		if (Lua_UnityEngine_Graphics.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Graphics.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Graphics.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Graphics.<>f__mg$cache17, typeof(Graphics));
	}

	// Token: 0x04019183 RID: 102787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019184 RID: 102788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019185 RID: 102789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019186 RID: 102790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019187 RID: 102791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019188 RID: 102792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019189 RID: 102793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401918A RID: 102794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401918B RID: 102795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401918C RID: 102796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401918D RID: 102797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401918E RID: 102798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401918F RID: 102799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019190 RID: 102800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019191 RID: 102801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019192 RID: 102802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019193 RID: 102803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019194 RID: 102804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019195 RID: 102805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019196 RID: 102806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019197 RID: 102807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019198 RID: 102808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019199 RID: 102809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401919A RID: 102810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
