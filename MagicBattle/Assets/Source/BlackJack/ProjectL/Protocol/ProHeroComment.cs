using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000656 RID: 1622
	[ProtoContract(Name = "ProHeroComment")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroComment : IExtensible
	{
		// Token: 0x0600587F RID: 22655 RVA: 0x0019B444 File Offset: 0x00199644
		public ProHeroComment()
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

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06005880 RID: 22656 RVA: 0x0019B4B8 File Offset: 0x001996B8
		// (set) Token: 0x06005881 RID: 22657 RVA: 0x0019B4C0 File Offset: 0x001996C0
		[ProtoMember(1, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06005882 RID: 22658 RVA: 0x0019B4CC File Offset: 0x001996CC
		[ProtoMember(2, Name = "CommentEntries", DataFormat = DataFormat.Default)]
		public List<ProHeroCommentEntry> CommentEntries
		{
			get
			{
				return this._CommentEntries;
			}
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0019B4D4 File Offset: 0x001996D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0019B4E4 File Offset: 0x001996E4
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

		// Token: 0x06005885 RID: 22661 RVA: 0x0019B5B0 File Offset: 0x001997B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroComment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400426C RID: 17004
		private long _LastUpdateTime;

		// Token: 0x0400426D RID: 17005
		private readonly List<ProHeroCommentEntry> _CommentEntries = new List<ProHeroCommentEntry>();

		// Token: 0x0400426E RID: 17006
		private IExtension extensionObject;

		// Token: 0x0400426F RID: 17007
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004270 RID: 17008
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004271 RID: 17009
		private LuaFunction m_ctor_hotfix;
	}
}
