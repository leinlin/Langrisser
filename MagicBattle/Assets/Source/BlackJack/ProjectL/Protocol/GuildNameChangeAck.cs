using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000780 RID: 1920
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildNameChangeAck")]
	[Serializable]
	public class GuildNameChangeAck : IExtensible
	{
		// Token: 0x06006369 RID: 25449 RVA: 0x001BEAD4 File Offset: 0x001BCCD4
		public GuildNameChangeAck()
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

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x001BEB3C File Offset: 0x001BCD3C
		// (set) Token: 0x0600636B RID: 25451 RVA: 0x001BEB44 File Offset: 0x001BCD44
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

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x001BEB50 File Offset: 0x001BCD50
		// (set) Token: 0x0600636D RID: 25453 RVA: 0x001BEB58 File Offset: 0x001BCD58
		[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x001BEB64 File Offset: 0x001BCD64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x001BEB74 File Offset: 0x001BCD74
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

		// Token: 0x06006370 RID: 25456 RVA: 0x001BEC40 File Offset: 0x001BCE40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildNameChangeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A7F RID: 19071
		private int _Result;

		// Token: 0x04004A80 RID: 19072
		private string _Name;

		// Token: 0x04004A81 RID: 19073
		private IExtension extensionObject;

		// Token: 0x04004A82 RID: 19074
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A83 RID: 19075
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A84 RID: 19076
		private LuaFunction m_ctor_hotfix;
	}
}
