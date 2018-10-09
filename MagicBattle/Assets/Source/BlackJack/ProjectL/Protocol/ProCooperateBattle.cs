using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000688 RID: 1672
	[ProtoContract(Name = "ProCooperateBattle")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProCooperateBattle : IExtensible
	{
		// Token: 0x06005B15 RID: 23317 RVA: 0x001A1B6C File Offset: 0x0019FD6C
		public ProCooperateBattle()
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

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x001A1BE0 File Offset: 0x0019FDE0
		// (set) Token: 0x06005B17 RID: 23319 RVA: 0x001A1BE8 File Offset: 0x0019FDE8
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

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06005B18 RID: 23320 RVA: 0x001A1BF4 File Offset: 0x0019FDF4
		[ProtoMember(2, Name = "LevelsCleared", DataFormat = DataFormat.Default)]
		public List<ProCooperateBattleLevel> LevelsCleared
		{
			get
			{
				return this._LevelsCleared;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x001A1BFC File Offset: 0x0019FDFC
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x001A1C04 File Offset: 0x0019FE04
		[ProtoMember(3, IsRequired = true, Name = "ChallengedNums", DataFormat = DataFormat.TwosComplement)]
		public int ChallengedNums
		{
			get
			{
				return this._ChallengedNums;
			}
			set
			{
				this._ChallengedNums = value;
			}
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x001A1C10 File Offset: 0x0019FE10
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x001A1C20 File Offset: 0x0019FE20
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

		// Token: 0x06005B1D RID: 23325 RVA: 0x001A1CEC File Offset: 0x0019FEEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProCooperateBattle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400442E RID: 17454
		private int _ConfigId;

		// Token: 0x0400442F RID: 17455
		private readonly List<ProCooperateBattleLevel> _LevelsCleared = new List<ProCooperateBattleLevel>();

		// Token: 0x04004430 RID: 17456
		private int _ChallengedNums;

		// Token: 0x04004431 RID: 17457
		private IExtension extensionObject;

		// Token: 0x04004432 RID: 17458
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004433 RID: 17459
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004434 RID: 17460
		private LuaFunction m_ctor_hotfix;
	}
}
