using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CB RID: 1995
	[ProtoContract(Name = "ModelSkinWearReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ModelSkinWearReq : IExtensible
	{
		// Token: 0x060065F2 RID: 26098 RVA: 0x001C7664 File Offset: 0x001C5864
		public ModelSkinWearReq()
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

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060065F3 RID: 26099 RVA: 0x001C76CC File Offset: 0x001C58CC
		// (set) Token: 0x060065F4 RID: 26100 RVA: 0x001C76D4 File Offset: 0x001C58D4
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060065F5 RID: 26101 RVA: 0x001C76E0 File Offset: 0x001C58E0
		// (set) Token: 0x060065F6 RID: 26102 RVA: 0x001C76E8 File Offset: 0x001C58E8
		[ProtoMember(2, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060065F7 RID: 26103 RVA: 0x001C76F4 File Offset: 0x001C58F4
		// (set) Token: 0x060065F8 RID: 26104 RVA: 0x001C76FC File Offset: 0x001C58FC
		[ProtoMember(3, IsRequired = true, Name = "modelSkinId", DataFormat = DataFormat.TwosComplement)]
		public int ModelSkinId
		{
			get
			{
				return this._modelSkinId;
			}
			set
			{
				this._modelSkinId = value;
			}
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x001C7708 File Offset: 0x001C5908
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x001C7718 File Offset: 0x001C5918
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

		// Token: 0x060065FB RID: 26107 RVA: 0x001C77E4 File Offset: 0x001C59E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ModelSkinWearReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C61 RID: 19553
		private int _HeroId;

		// Token: 0x04004C62 RID: 19554
		private int _JobRelatedId;

		// Token: 0x04004C63 RID: 19555
		private int _modelSkinId;

		// Token: 0x04004C64 RID: 19556
		private IExtension extensionObject;

		// Token: 0x04004C65 RID: 19557
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C66 RID: 19558
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C67 RID: 19559
		private LuaFunction m_ctor_hotfix;
	}
}
