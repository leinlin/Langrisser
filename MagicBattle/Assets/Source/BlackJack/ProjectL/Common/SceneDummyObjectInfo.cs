using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000333 RID: 819
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SceneDummyObjectInfo")]
	[Serializable]
	public class SceneDummyObjectInfo : IExtensible
	{
		// Token: 0x060030AD RID: 12461 RVA: 0x000BF350 File Offset: 0x000BD550
		public SceneDummyObjectInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x000BF3B8 File Offset: 0x000BD5B8
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x000BF3C0 File Offset: 0x000BD5C0
		[ProtoMember(1, IsRequired = true, Name = "objType", DataFormat = DataFormat.TwosComplement)]
		public uint ObjType
		{
			get
			{
				return this._objType;
			}
			set
			{
				this._objType = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x000BF3CC File Offset: 0x000BD5CC
		// (set) Token: 0x060030B1 RID: 12465 RVA: 0x000BF3D4 File Offset: 0x000BD5D4
		[ProtoMember(2, IsRequired = true, Name = "objConfId", DataFormat = DataFormat.TwosComplement)]
		public int ObjConfId
		{
			get
			{
				return this._objConfId;
			}
			set
			{
				this._objConfId = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x000BF3E0 File Offset: 0x000BD5E0
		// (set) Token: 0x060030B3 RID: 12467 RVA: 0x000BF3E8 File Offset: 0x000BD5E8
		[ProtoMember(3, IsRequired = true, Name = "location", DataFormat = DataFormat.Default)]
		public PVector3D Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x000BF3F4 File Offset: 0x000BD5F4
		// (set) Token: 0x060030B5 RID: 12469 RVA: 0x000BF3FC File Offset: 0x000BD5FC
		[ProtoMember(4, IsRequired = true, Name = "rotation", DataFormat = DataFormat.Default)]
		public PVector3D Rotation
		{
			get
			{
				return this._rotation;
			}
			set
			{
				this._rotation = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x000BF408 File Offset: 0x000BD608
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x000BF410 File Offset: 0x000BD610
		[ProtoMember(5, IsRequired = true, Name = "scale", DataFormat = DataFormat.FixedSize)]
		public float Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000BF41C File Offset: 0x000BD61C
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x000BF424 File Offset: 0x000BD624
		[ProtoMember(6, IsRequired = true, Name = "createOnSceneCreate", DataFormat = DataFormat.Default)]
		public bool CreateOnSceneCreate
		{
			get
			{
				return this._createOnSceneCreate;
			}
			set
			{
				this._createOnSceneCreate = value;
			}
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000BF430 File Offset: 0x000BD630
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000BF440 File Offset: 0x000BD640
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000BF50C File Offset: 0x000BD70C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SceneDummyObjectInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400251C RID: 9500
		private uint _objType;

		// Token: 0x0400251D RID: 9501
		private int _objConfId;

		// Token: 0x0400251E RID: 9502
		private PVector3D _location;

		// Token: 0x0400251F RID: 9503
		private PVector3D _rotation;

		// Token: 0x04002520 RID: 9504
		private float _scale;

		// Token: 0x04002521 RID: 9505
		private bool _createOnSceneCreate;

		// Token: 0x04002522 RID: 9506
		private IExtension extensionObject;

		// Token: 0x04002523 RID: 9507
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002524 RID: 9508
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002525 RID: 9509
		private LuaFunction m_ctor_hotfix;
	}
}
