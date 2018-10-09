using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063C RID: 1596
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroCommentEntryPraiseAck")]
	[Serializable]
	public class HeroCommentEntryPraiseAck : IExtensible
	{
		// Token: 0x06005754 RID: 22356 RVA: 0x00198060 File Offset: 0x00196260
		public HeroCommentEntryPraiseAck()
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

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06005755 RID: 22357 RVA: 0x001980C8 File Offset: 0x001962C8
		// (set) Token: 0x06005756 RID: 22358 RVA: 0x001980D0 File Offset: 0x001962D0
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06005757 RID: 22359 RVA: 0x001980DC File Offset: 0x001962DC
		// (set) Token: 0x06005758 RID: 22360 RVA: 0x001980E4 File Offset: 0x001962E4
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

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x001980F0 File Offset: 0x001962F0
		// (set) Token: 0x0600575A RID: 22362 RVA: 0x001980F8 File Offset: 0x001962F8
		[ProtoMember(3, IsRequired = true, Name = "entryInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong EntryInstanceId
		{
			get
			{
				return this._entryInstanceId;
			}
			set
			{
				this._entryInstanceId = value;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x00198104 File Offset: 0x00196304
		// (set) Token: 0x0600575C RID: 22364 RVA: 0x0019810C File Offset: 0x0019630C
		[ProtoMember(4, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x0600575D RID: 22365 RVA: 0x00198118 File Offset: 0x00196318
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00198128 File Offset: 0x00196328
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

		// Token: 0x0600575F RID: 22367 RVA: 0x001981F4 File Offset: 0x001963F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentEntryPraiseAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004199 RID: 16793
		private int _Result;

		// Token: 0x0400419A RID: 16794
		private int _HeroId;

		// Token: 0x0400419B RID: 16795
		private ulong _entryInstanceId;

		// Token: 0x0400419C RID: 16796
		private long _LastUpdateTime;

		// Token: 0x0400419D RID: 16797
		private IExtension extensionObject;

		// Token: 0x0400419E RID: 16798
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400419F RID: 16799
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041A0 RID: 16800
		private LuaFunction m_ctor_hotfix;
	}
}
