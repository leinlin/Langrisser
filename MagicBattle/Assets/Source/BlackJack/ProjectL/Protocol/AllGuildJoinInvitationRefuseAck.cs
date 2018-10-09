using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000766 RID: 1894
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AllGuildJoinInvitationRefuseAck")]
	[Serializable]
	public class AllGuildJoinInvitationRefuseAck : IExtensible
	{
		// Token: 0x060062A7 RID: 25255 RVA: 0x001BBB9C File Offset: 0x001B9D9C
		public AllGuildJoinInvitationRefuseAck()
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

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x060062A8 RID: 25256 RVA: 0x001BBC04 File Offset: 0x001B9E04
		// (set) Token: 0x060062A9 RID: 25257 RVA: 0x001BBC0C File Offset: 0x001B9E0C
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060062AA RID: 25258 RVA: 0x001BBC18 File Offset: 0x001B9E18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x001BBC28 File Offset: 0x001B9E28
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

		// Token: 0x060062AC RID: 25260 RVA: 0x001BBCF4 File Offset: 0x001B9EF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AllGuildJoinInvitationRefuseAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049E8 RID: 18920
		private int _Result;

		// Token: 0x040049E9 RID: 18921
		private IExtension extensionObject;

		// Token: 0x040049EA RID: 18922
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049EB RID: 18923
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049EC RID: 18924
		private LuaFunction m_ctor_hotfix;
	}
}
