using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006EB RID: 1771
	[ProtoContract(Name = "FriendshipPointsClaimAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendshipPointsClaimAck : IExtensible
	{
		// Token: 0x06005E77 RID: 24183 RVA: 0x001AD54C File Offset: 0x001AB74C
		public FriendshipPointsClaimAck()
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

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06005E78 RID: 24184 RVA: 0x001AD5C0 File Offset: 0x001AB7C0
		// (set) Token: 0x06005E79 RID: 24185 RVA: 0x001AD5C8 File Offset: 0x001AB7C8
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

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06005E7A RID: 24186 RVA: 0x001AD5D4 File Offset: 0x001AB7D4
		// (set) Token: 0x06005E7B RID: 24187 RVA: 0x001AD5DC File Offset: 0x001AB7DC
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendshipPointsClaimReq Req
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

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06005E7C RID: 24188 RVA: 0x001AD5E8 File Offset: 0x001AB7E8
		[ProtoMember(3, Name = "ReceivedUserIds", DataFormat = DataFormat.Default)]
		public List<string> ReceivedUserIds
		{
			get
			{
				return this._ReceivedUserIds;
			}
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x001AD5F0 File Offset: 0x001AB7F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x001AD600 File Offset: 0x001AB800
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

		// Token: 0x06005E7F RID: 24191 RVA: 0x001AD6CC File Offset: 0x001AB8CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendshipPointsClaimAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046C0 RID: 18112
		private int _Result;

		// Token: 0x040046C1 RID: 18113
		private FriendshipPointsClaimReq _Req;

		// Token: 0x040046C2 RID: 18114
		private readonly List<string> _ReceivedUserIds = new List<string>();

		// Token: 0x040046C3 RID: 18115
		private IExtension extensionObject;

		// Token: 0x040046C4 RID: 18116
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046C5 RID: 18117
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046C6 RID: 18118
		private LuaFunction m_ctor_hotfix;
	}
}
