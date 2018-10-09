using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064D RID: 1613
	[ProtoContract(Name = "ProRandomStore")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRandomStore : IExtensible
	{
		// Token: 0x06005823 RID: 22563 RVA: 0x0019A2E0 File Offset: 0x001984E0
		public ProRandomStore()
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

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x0019A354 File Offset: 0x00198554
		// (set) Token: 0x06005825 RID: 22565 RVA: 0x0019A35C File Offset: 0x0019855C
		[ProtoMember(1, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0019A368 File Offset: 0x00198568
		// (set) Token: 0x06005827 RID: 22567 RVA: 0x0019A370 File Offset: 0x00198570
		[ProtoMember(2, IsRequired = true, Name = "NextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushTime
		{
			get
			{
				return this._NextFlushTime;
			}
			set
			{
				this._NextFlushTime = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0019A37C File Offset: 0x0019857C
		[ProtoMember(3, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ProRandomStoreItem> Items
		{
			get
			{
				return this._Items;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x0019A384 File Offset: 0x00198584
		// (set) Token: 0x0600582A RID: 22570 RVA: 0x0019A38C File Offset: 0x0019858C
		[ProtoMember(4, IsRequired = true, Name = "ManualFlushNums", DataFormat = DataFormat.TwosComplement)]
		public int ManualFlushNums
		{
			get
			{
				return this._ManualFlushNums;
			}
			set
			{
				this._ManualFlushNums = value;
			}
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0019A398 File Offset: 0x00198598
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0019A3A8 File Offset: 0x001985A8
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

		// Token: 0x0600582D RID: 22573 RVA: 0x0019A474 File Offset: 0x00198674
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRandomStore));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400422A RID: 16938
		private int _StoreId;

		// Token: 0x0400422B RID: 16939
		private long _NextFlushTime;

		// Token: 0x0400422C RID: 16940
		private readonly List<ProRandomStoreItem> _Items = new List<ProRandomStoreItem>();

		// Token: 0x0400422D RID: 16941
		private int _ManualFlushNums;

		// Token: 0x0400422E RID: 16942
		private IExtension extensionObject;

		// Token: 0x0400422F RID: 16943
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004230 RID: 16944
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004231 RID: 16945
		private LuaFunction m_ctor_hotfix;
	}
}
