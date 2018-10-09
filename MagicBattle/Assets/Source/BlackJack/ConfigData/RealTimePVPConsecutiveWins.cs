using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FD RID: 765
	[ProtoContract(Name = "RealTimePVPConsecutiveWins")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPConsecutiveWins : IExtensible
	{
		// Token: 0x06002E07 RID: 11783 RVA: 0x000B85EC File Offset: 0x000B67EC
		public RealTimePVPConsecutiveWins()
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

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000B8654 File Offset: 0x000B6854
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x000B865C File Offset: 0x000B685C
		[ProtoMember(1, IsRequired = true, Name = "ConsecutiveWins", DataFormat = DataFormat.TwosComplement)]
		public int ConsecutiveWins
		{
			get
			{
				return this._ConsecutiveWins;
			}
			set
			{
				this._ConsecutiveWins = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x000B8668 File Offset: 0x000B6868
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x000B8670 File Offset: 0x000B6870
		[ProtoMember(2, IsRequired = true, Name = "ScoreBonus", DataFormat = DataFormat.TwosComplement)]
		public int ScoreBonus
		{
			get
			{
				return this._ScoreBonus;
			}
			set
			{
				this._ScoreBonus = value;
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000B867C File Offset: 0x000B687C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000B868C File Offset: 0x000B688C
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

		// Token: 0x06002E0E RID: 11790 RVA: 0x000B8758 File Offset: 0x000B6958
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPConsecutiveWins));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002356 RID: 9046
		private int _ConsecutiveWins;

		// Token: 0x04002357 RID: 9047
		private int _ScoreBonus;

		// Token: 0x04002358 RID: 9048
		private IExtension extensionObject;

		// Token: 0x04002359 RID: 9049
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400235A RID: 9050
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400235B RID: 9051
		private LuaFunction m_ctor_hotfix;
	}
}
