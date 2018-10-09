using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075C RID: 1884
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinApplyRefuseAck")]
	[Serializable]
	public class GuildJoinApplyRefuseAck : IExtensible
	{
		// Token: 0x06006266 RID: 25190 RVA: 0x001BA9E0 File Offset: 0x001B8BE0
		public GuildJoinApplyRefuseAck()
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

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06006267 RID: 25191 RVA: 0x001BAA48 File Offset: 0x001B8C48
		// (set) Token: 0x06006268 RID: 25192 RVA: 0x001BAA50 File Offset: 0x001B8C50
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06006269 RID: 25193 RVA: 0x001BAA5C File Offset: 0x001B8C5C
		// (set) Token: 0x0600626A RID: 25194 RVA: 0x001BAA64 File Offset: 0x001B8C64
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x001BAA70 File Offset: 0x001B8C70
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x001BAA80 File Offset: 0x001B8C80
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

		// Token: 0x0600626D RID: 25197 RVA: 0x001BAB4C File Offset: 0x001B8D4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyRefuseAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049B3 RID: 18867
		private int _Result;

		// Token: 0x040049B4 RID: 18868
		private string _UserId;

		// Token: 0x040049B5 RID: 18869
		private IExtension extensionObject;

		// Token: 0x040049B6 RID: 18870
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049B7 RID: 18871
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049B8 RID: 18872
		private LuaFunction m_ctor_hotfix;
	}
}
