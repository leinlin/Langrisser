using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079D RID: 1949
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroDungeonLevelRaidReq")]
	[Serializable]
	public class HeroDungeonLevelRaidReq : IExtensible
	{
		// Token: 0x06006447 RID: 25671 RVA: 0x001C1FAC File Offset: 0x001C01AC
		public HeroDungeonLevelRaidReq()
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

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x001C2014 File Offset: 0x001C0214
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x001C201C File Offset: 0x001C021C
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x001C2028 File Offset: 0x001C0228
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x001C2030 File Offset: 0x001C0230
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

		// Token: 0x0600644C RID: 25676 RVA: 0x001C203C File Offset: 0x001C023C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x001C204C File Offset: 0x001C024C
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

		// Token: 0x0600644E RID: 25678 RVA: 0x001C2118 File Offset: 0x001C0318
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelRaidReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B2B RID: 19243
		private int _LevelId;

		// Token: 0x04004B2C RID: 19244
		private int _Nums;

		// Token: 0x04004B2D RID: 19245
		private IExtension extensionObject;

		// Token: 0x04004B2E RID: 19246
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B2F RID: 19247
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B30 RID: 19248
		private LuaFunction m_ctor_hotfix;
	}
}
