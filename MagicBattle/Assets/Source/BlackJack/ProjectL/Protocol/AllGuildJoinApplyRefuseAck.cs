using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075E RID: 1886
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AllGuildJoinApplyRefuseAck")]
	[Serializable]
	public class AllGuildJoinApplyRefuseAck : IExtensible
	{
		// Token: 0x06006272 RID: 25202 RVA: 0x001BAD60 File Offset: 0x001B8F60
		public AllGuildJoinApplyRefuseAck()
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

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06006273 RID: 25203 RVA: 0x001BADC8 File Offset: 0x001B8FC8
		// (set) Token: 0x06006274 RID: 25204 RVA: 0x001BADD0 File Offset: 0x001B8FD0
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

		// Token: 0x06006275 RID: 25205 RVA: 0x001BADDC File Offset: 0x001B8FDC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x001BADEC File Offset: 0x001B8FEC
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

		// Token: 0x06006277 RID: 25207 RVA: 0x001BAEB8 File Offset: 0x001B90B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AllGuildJoinApplyRefuseAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049BD RID: 18877
		private int _Result;

		// Token: 0x040049BE RID: 18878
		private IExtension extensionObject;

		// Token: 0x040049BF RID: 18879
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049C0 RID: 18880
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049C1 RID: 18881
		private LuaFunction m_ctor_hotfix;
	}
}
