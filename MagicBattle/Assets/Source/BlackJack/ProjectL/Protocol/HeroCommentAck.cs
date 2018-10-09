using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063A RID: 1594
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroCommentAck")]
	[Serializable]
	public class HeroCommentAck : IExtensible
	{
		// Token: 0x0600573E RID: 22334 RVA: 0x00197C7C File Offset: 0x00195E7C
		public HeroCommentAck()
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

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00197CE4 File Offset: 0x00195EE4
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x00197CEC File Offset: 0x00195EEC
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

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x00197CF8 File Offset: 0x00195EF8
		// (set) Token: 0x06005742 RID: 22338 RVA: 0x00197D00 File Offset: 0x00195F00
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x00197D0C File Offset: 0x00195F0C
		// (set) Token: 0x06005744 RID: 22340 RVA: 0x00197D14 File Offset: 0x00195F14
		[ProtoMember(3, IsRequired = false, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x00197D20 File Offset: 0x00195F20
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x00197D28 File Offset: 0x00195F28
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "CommentEntry", DataFormat = DataFormat.Default)]
		public ProHeroCommentEntry CommentEntry
		{
			get
			{
				return this._CommentEntry;
			}
			set
			{
				this._CommentEntry = value;
			}
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00197D34 File Offset: 0x00195F34
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x00197D44 File Offset: 0x00195F44
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

		// Token: 0x06005749 RID: 22345 RVA: 0x00197E10 File Offset: 0x00196010
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400418A RID: 16778
		private int _Result;

		// Token: 0x0400418B RID: 16779
		private int _HeroId;

		// Token: 0x0400418C RID: 16780
		private long _LastUpdateTime;

		// Token: 0x0400418D RID: 16781
		private ProHeroCommentEntry _CommentEntry;

		// Token: 0x0400418E RID: 16782
		private IExtension extensionObject;

		// Token: 0x0400418F RID: 16783
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004190 RID: 16784
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004191 RID: 16785
		private LuaFunction m_ctor_hotfix;
	}
}
