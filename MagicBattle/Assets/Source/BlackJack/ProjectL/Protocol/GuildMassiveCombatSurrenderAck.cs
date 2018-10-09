using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200078C RID: 1932
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatSurrenderAck")]
	[Serializable]
	public class GuildMassiveCombatSurrenderAck : IExtensible
	{
		// Token: 0x060063B0 RID: 25520 RVA: 0x001BFFD4 File Offset: 0x001BE1D4
		public GuildMassiveCombatSurrenderAck()
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

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x001C003C File Offset: 0x001BE23C
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x001C0044 File Offset: 0x001BE244
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

		// Token: 0x060063B3 RID: 25523 RVA: 0x001C0050 File Offset: 0x001BE250
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x001C0060 File Offset: 0x001BE260
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

		// Token: 0x060063B5 RID: 25525 RVA: 0x001C012C File Offset: 0x001BE32C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatSurrenderAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004ABB RID: 19131
		private int _Result;

		// Token: 0x04004ABC RID: 19132
		private IExtension extensionObject;

		// Token: 0x04004ABD RID: 19133
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004ABE RID: 19134
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004ABF RID: 19135
		private LuaFunction m_ctor_hotfix;
	}
}
