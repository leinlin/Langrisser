using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000787 RID: 1927
	[ProtoContract(Name = "GuildMassiveCombatStartReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildMassiveCombatStartReq : IExtensible
	{
		// Token: 0x06006394 RID: 25492 RVA: 0x001BF728 File Offset: 0x001BD928
		public GuildMassiveCombatStartReq()
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

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x001BF790 File Offset: 0x001BD990
		// (set) Token: 0x06006396 RID: 25494 RVA: 0x001BF798 File Offset: 0x001BD998
		[ProtoMember(1, IsRequired = true, Name = "Difficulty", DataFormat = DataFormat.TwosComplement)]
		public int Difficulty
		{
			get
			{
				return this._Difficulty;
			}
			set
			{
				this._Difficulty = value;
			}
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x001BF7A4 File Offset: 0x001BD9A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x001BF7B4 File Offset: 0x001BD9B4
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

		// Token: 0x06006399 RID: 25497 RVA: 0x001BF880 File Offset: 0x001BDA80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatStartReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AA3 RID: 19107
		private int _Difficulty;

		// Token: 0x04004AA4 RID: 19108
		private IExtension extensionObject;

		// Token: 0x04004AA5 RID: 19109
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AA6 RID: 19110
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AA7 RID: 19111
		private LuaFunction m_ctor_hotfix;
	}
}
