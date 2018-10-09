using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C8 RID: 1736
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendBlockAck")]
	[Serializable]
	public class FriendBlockAck : IExtensible
	{
		// Token: 0x06005D90 RID: 23952 RVA: 0x001A96D4 File Offset: 0x001A78D4
		public FriendBlockAck()
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x001A973C File Offset: 0x001A793C
		// (set) Token: 0x06005D92 RID: 23954 RVA: 0x001A9744 File Offset: 0x001A7944
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

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x001A9750 File Offset: 0x001A7950
		// (set) Token: 0x06005D94 RID: 23956 RVA: 0x001A9758 File Offset: 0x001A7958
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendBlockReq Req
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

		// Token: 0x06005D95 RID: 23957 RVA: 0x001A9764 File Offset: 0x001A7964
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x001A9774 File Offset: 0x001A7974
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

		// Token: 0x06005D97 RID: 23959 RVA: 0x001A9840 File Offset: 0x001A7A40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendBlockAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004602 RID: 17922
		private int _Result;

		// Token: 0x04004603 RID: 17923
		private FriendBlockReq _Req;

		// Token: 0x04004604 RID: 17924
		private IExtension extensionObject;

		// Token: 0x04004605 RID: 17925
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004606 RID: 17926
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004607 RID: 17927
		private LuaFunction m_ctor_hotfix;
	}
}
