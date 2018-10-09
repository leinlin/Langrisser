using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000624 RID: 1572
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatVoiceContentReq")]
	[Serializable]
	public class ChatVoiceContentReq : IExtensible
	{
		// Token: 0x0600567A RID: 22138 RVA: 0x0019532C File Offset: 0x0019352C
		public ChatVoiceContentReq()
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

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x00195394 File Offset: 0x00193594
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x0019539C File Offset: 0x0019359C
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x001953A8 File Offset: 0x001935A8
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x001953B0 File Offset: 0x001935B0
		[ProtoMember(2, IsRequired = true, Name = "ChannelId", DataFormat = DataFormat.TwosComplement)]
		public int ChannelId
		{
			get
			{
				return this._ChannelId;
			}
			set
			{
				this._ChannelId = value;
			}
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x001953BC File Offset: 0x001935BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x001953CC File Offset: 0x001935CC
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

		// Token: 0x06005681 RID: 22145 RVA: 0x00195498 File Offset: 0x00193698
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatVoiceContentReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040F9 RID: 16633
		private ulong _InstanceId;

		// Token: 0x040040FA RID: 16634
		private int _ChannelId;

		// Token: 0x040040FB RID: 16635
		private IExtension extensionObject;

		// Token: 0x040040FC RID: 16636
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040FD RID: 16637
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040FE RID: 16638
		private LuaFunction m_ctor_hotfix;
	}
}
