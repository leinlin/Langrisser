using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FA RID: 1786
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaTicketsBuyAck")]
	[Serializable]
	public class ArenaTicketsBuyAck : IExtensible
	{
		// Token: 0x06005F23 RID: 24355 RVA: 0x001AF2E8 File Offset: 0x001AD4E8
		public ArenaTicketsBuyAck()
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

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06005F24 RID: 24356 RVA: 0x001AF350 File Offset: 0x001AD550
		// (set) Token: 0x06005F25 RID: 24357 RVA: 0x001AF358 File Offset: 0x001AD558
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

		// Token: 0x06005F26 RID: 24358 RVA: 0x001AF364 File Offset: 0x001AD564
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x001AF374 File Offset: 0x001AD574
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

		// Token: 0x06005F28 RID: 24360 RVA: 0x001AF440 File Offset: 0x001AD640
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaTicketsBuyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004735 RID: 18229
		private int _Result;

		// Token: 0x04004736 RID: 18230
		private IExtension extensionObject;

		// Token: 0x04004737 RID: 18231
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004738 RID: 18232
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004739 RID: 18233
		private LuaFunction m_ctor_hotfix;
	}
}
