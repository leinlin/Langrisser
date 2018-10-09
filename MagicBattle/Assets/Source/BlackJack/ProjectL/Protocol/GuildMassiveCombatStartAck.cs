using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000788 RID: 1928
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatStartAck")]
	[Serializable]
	public class GuildMassiveCombatStartAck : IExtensible
	{
		// Token: 0x0600639A RID: 25498 RVA: 0x001BF8E8 File Offset: 0x001BDAE8
		public GuildMassiveCombatStartAck()
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

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600639B RID: 25499 RVA: 0x001BF950 File Offset: 0x001BDB50
		// (set) Token: 0x0600639C RID: 25500 RVA: 0x001BF958 File Offset: 0x001BDB58
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x001BF964 File Offset: 0x001BDB64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x001BF974 File Offset: 0x001BDB74
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

		// Token: 0x0600639F RID: 25503 RVA: 0x001BFA40 File Offset: 0x001BDC40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatStartAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AA8 RID: 19112
		private int _Result;

		// Token: 0x04004AA9 RID: 19113
		private IExtension extensionObject;

		// Token: 0x04004AAA RID: 19114
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AAB RID: 19115
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AAC RID: 19116
		private LuaFunction m_ctor_hotfix;
	}
}
