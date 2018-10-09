using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D6 RID: 1750
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BusinessCardDescUpdateAck")]
	[Serializable]
	public class BusinessCardDescUpdateAck : IExtensible
	{
		// Token: 0x06005DF4 RID: 24052 RVA: 0x001AB028 File Offset: 0x001A9228
		public BusinessCardDescUpdateAck()
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x001AB090 File Offset: 0x001A9290
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x001AB098 File Offset: 0x001A9298
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x001AB0A4 File Offset: 0x001A92A4
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x001AB0AC File Offset: 0x001A92AC
		[ProtoMember(2, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x001AB0B8 File Offset: 0x001A92B8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x001AB0C8 File Offset: 0x001A92C8
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

		// Token: 0x06005DFB RID: 24059 RVA: 0x001AB194 File Offset: 0x001A9394
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardDescUpdateAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004652 RID: 18002
		private int _Result;

		// Token: 0x04004653 RID: 18003
		private string _Desc;

		// Token: 0x04004654 RID: 18004
		private IExtension extensionObject;

		// Token: 0x04004655 RID: 18005
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004656 RID: 18006
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004657 RID: 18007
		private LuaFunction m_ctor_hotfix;
	}
}
