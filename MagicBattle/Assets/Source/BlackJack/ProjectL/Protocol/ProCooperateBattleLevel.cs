using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000687 RID: 1671
	[ProtoContract(Name = "ProCooperateBattleLevel")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProCooperateBattleLevel : IExtensible
	{
		// Token: 0x06005B0D RID: 23309 RVA: 0x001A1998 File Offset: 0x0019FB98
		public ProCooperateBattleLevel()
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06005B0E RID: 23310 RVA: 0x001A1A00 File Offset: 0x0019FC00
		// (set) Token: 0x06005B0F RID: 23311 RVA: 0x001A1A08 File Offset: 0x0019FC08
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x001A1A14 File Offset: 0x0019FC14
		// (set) Token: 0x06005B11 RID: 23313 RVA: 0x001A1A1C File Offset: 0x0019FC1C
		[ProtoMember(2, IsRequired = true, Name = "FirstClear", DataFormat = DataFormat.TwosComplement)]
		public long FirstClear
		{
			get
			{
				return this._FirstClear;
			}
			set
			{
				this._FirstClear = value;
			}
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x001A1A28 File Offset: 0x0019FC28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x001A1A38 File Offset: 0x0019FC38
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

		// Token: 0x06005B14 RID: 23316 RVA: 0x001A1B04 File Offset: 0x0019FD04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProCooperateBattleLevel));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004428 RID: 17448
		private int _ConfigId;

		// Token: 0x04004429 RID: 17449
		private long _FirstClear;

		// Token: 0x0400442A RID: 17450
		private IExtension extensionObject;

		// Token: 0x0400442B RID: 17451
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400442C RID: 17452
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400442D RID: 17453
		private LuaFunction m_ctor_hotfix;
	}
}
