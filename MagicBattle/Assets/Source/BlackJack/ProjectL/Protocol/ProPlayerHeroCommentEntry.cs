using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000658 RID: 1624
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProPlayerHeroCommentEntry")]
	[Serializable]
	public class ProPlayerHeroCommentEntry : IExtensible
	{
		// Token: 0x06005898 RID: 22680 RVA: 0x0019B850 File Offset: 0x00199A50
		public ProPlayerHeroCommentEntry()
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

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x0019B8CC File Offset: 0x00199ACC
		// (set) Token: 0x0600589A RID: 22682 RVA: 0x0019B8D4 File Offset: 0x00199AD4
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x0019B8E0 File Offset: 0x00199AE0
		[ProtoMember(2, Name = "CommentedEntryInstanceIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> CommentedEntryInstanceIds
		{
			get
			{
				return this._CommentedEntryInstanceIds;
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x0019B8E8 File Offset: 0x00199AE8
		[ProtoMember(3, Name = "PraisedEntryInstanceIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> PraisedEntryInstanceIds
		{
			get
			{
				return this._PraisedEntryInstanceIds;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x0019B8F0 File Offset: 0x00199AF0
		// (set) Token: 0x0600589E RID: 22686 RVA: 0x0019B8F8 File Offset: 0x00199AF8
		[ProtoMember(4, IsRequired = true, Name = "CommentedNums", DataFormat = DataFormat.TwosComplement)]
		public int CommentedNums
		{
			get
			{
				return this._CommentedNums;
			}
			set
			{
				this._CommentedNums = value;
			}
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x0019B904 File Offset: 0x00199B04
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0019B914 File Offset: 0x00199B14
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

		// Token: 0x060058A1 RID: 22689 RVA: 0x0019B9E0 File Offset: 0x00199BE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProPlayerHeroCommentEntry));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400427D RID: 17021
		private int _HeroId;

		// Token: 0x0400427E RID: 17022
		private readonly List<ulong> _CommentedEntryInstanceIds = new List<ulong>();

		// Token: 0x0400427F RID: 17023
		private readonly List<ulong> _PraisedEntryInstanceIds = new List<ulong>();

		// Token: 0x04004280 RID: 17024
		private int _CommentedNums;

		// Token: 0x04004281 RID: 17025
		private IExtension extensionObject;

		// Token: 0x04004282 RID: 17026
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004283 RID: 17027
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004284 RID: 17028
		private LuaFunction m_ctor_hotfix;
	}
}
