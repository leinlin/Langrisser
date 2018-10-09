using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200078F RID: 1935
	[ProtoContract(Name = "GuildMassiveCombatAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildMassiveCombatAttackReq : IExtensible
	{
		// Token: 0x060063C2 RID: 25538 RVA: 0x001C0514 File Offset: 0x001BE714
		public GuildMassiveCombatAttackReq()
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

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x001C0588 File Offset: 0x001BE788
		// (set) Token: 0x060063C4 RID: 25540 RVA: 0x001C0590 File Offset: 0x001BE790
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

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x001C059C File Offset: 0x001BE79C
		[ProtoMember(2, Name = "HeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroIds
		{
			get
			{
				return this._HeroIds;
			}
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x001C05A4 File Offset: 0x001BE7A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x001C05B4 File Offset: 0x001BE7B4
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

		// Token: 0x060063C8 RID: 25544 RVA: 0x001C0680 File Offset: 0x001BE880
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004ACA RID: 19146
		private int _LevelId;

		// Token: 0x04004ACB RID: 19147
		private readonly List<int> _HeroIds = new List<int>();

		// Token: 0x04004ACC RID: 19148
		private IExtension extensionObject;

		// Token: 0x04004ACD RID: 19149
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004ACE RID: 19150
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004ACF RID: 19151
		private LuaFunction m_ctor_hotfix;
	}
}
