using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000334 RID: 820
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SceneObject3DInfo")]
	[Serializable]
	public class SceneObject3DInfo : IExtensible
	{
		// Token: 0x060030BD RID: 12477 RVA: 0x000BF574 File Offset: 0x000BD774
		public SceneObject3DInfo()
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

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x000BF5DC File Offset: 0x000BD7DC
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x000BF5E4 File Offset: 0x000BD7E4
		[ProtoMember(1, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				this._Index = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000BF5F0 File Offset: 0x000BD7F0
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x000BF5F8 File Offset: 0x000BD7F8
		[ProtoMember(2, IsRequired = true, Name = "location", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000BF604 File Offset: 0x000BD804
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x000BF60C File Offset: 0x000BD80C
		[ProtoMember(3, IsRequired = false, Name = "collision", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public CollisionInfo Collision
		{
			get
			{
				return this._collision;
			}
			set
			{
				this._collision = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000BF618 File Offset: 0x000BD818
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x000BF620 File Offset: 0x000BD820
		[ProtoMember(4, IsRequired = true, Name = "assetPath", DataFormat = DataFormat.Default)]
		public string AssetPath
		{
			get
			{
				return this._assetPath;
			}
			set
			{
				this._assetPath = value;
			}
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000BF62C File Offset: 0x000BD82C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000BF63C File Offset: 0x000BD83C
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

		// Token: 0x060030C8 RID: 12488 RVA: 0x000BF708 File Offset: 0x000BD908
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SceneObject3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002526 RID: 9510
		private int _Index;

		// Token: 0x04002527 RID: 9511
		private PVector3D _location;

		// Token: 0x04002528 RID: 9512
		private CollisionInfo _collision;

		// Token: 0x04002529 RID: 9513
		private string _assetPath;

		// Token: 0x0400252A RID: 9514
		private IExtension extensionObject;

		// Token: 0x0400252B RID: 9515
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400252C RID: 9516
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400252D RID: 9517
		private LuaFunction m_ctor_hotfix;
	}
}
