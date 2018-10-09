using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081C RID: 2076
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RiftLevelRaidReq")]
	[Serializable]
	public class RiftLevelRaidReq : IExtensible
	{
		// Token: 0x060068A7 RID: 26791 RVA: 0x001D80F8 File Offset: 0x001D62F8
		public RiftLevelRaidReq()
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

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060068A8 RID: 26792 RVA: 0x001D8160 File Offset: 0x001D6360
		// (set) Token: 0x060068A9 RID: 26793 RVA: 0x001D8168 File Offset: 0x001D6368
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x001D8174 File Offset: 0x001D6374
		// (set) Token: 0x060068AB RID: 26795 RVA: 0x001D817C File Offset: 0x001D637C
		[ProtoMember(2, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x001D8188 File Offset: 0x001D6388
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x001D8198 File Offset: 0x001D6398
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

		// Token: 0x060068AE RID: 26798 RVA: 0x001D8264 File Offset: 0x001D6464
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelRaidReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050A7 RID: 20647
		private int _LevelId;

		// Token: 0x040050A8 RID: 20648
		private int _Nums;

		// Token: 0x040050A9 RID: 20649
		private IExtension extensionObject;

		// Token: 0x040050AA RID: 20650
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050AB RID: 20651
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050AC RID: 20652
		private LuaFunction m_ctor_hotfix;
	}
}
