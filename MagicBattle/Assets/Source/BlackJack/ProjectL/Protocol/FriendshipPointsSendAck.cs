using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E9 RID: 1769
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendshipPointsSendAck")]
	[Serializable]
	public class FriendshipPointsSendAck : IExtensible
	{
		// Token: 0x06005E69 RID: 24169 RVA: 0x001AD1A4 File Offset: 0x001AB3A4
		public FriendshipPointsSendAck()
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

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x001AD218 File Offset: 0x001AB418
		// (set) Token: 0x06005E6B RID: 24171 RVA: 0x001AD220 File Offset: 0x001AB420
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

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06005E6C RID: 24172 RVA: 0x001AD22C File Offset: 0x001AB42C
		// (set) Token: 0x06005E6D RID: 24173 RVA: 0x001AD234 File Offset: 0x001AB434
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendshipPointsSendReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06005E6E RID: 24174 RVA: 0x001AD240 File Offset: 0x001AB440
		[ProtoMember(3, Name = "SentUserIds", DataFormat = DataFormat.Default)]
		public List<string> SentUserIds
		{
			get
			{
				return this._SentUserIds;
			}
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x001AD248 File Offset: 0x001AB448
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x001AD258 File Offset: 0x001AB458
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

		// Token: 0x06005E71 RID: 24177 RVA: 0x001AD324 File Offset: 0x001AB524
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendshipPointsSendAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046B4 RID: 18100
		private int _Result;

		// Token: 0x040046B5 RID: 18101
		private FriendshipPointsSendReq _Req;

		// Token: 0x040046B6 RID: 18102
		private readonly List<string> _SentUserIds = new List<string>();

		// Token: 0x040046B7 RID: 18103
		private IExtension extensionObject;

		// Token: 0x040046B8 RID: 18104
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046B9 RID: 18105
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046BA RID: 18106
		private LuaFunction m_ctor_hotfix;
	}
}
