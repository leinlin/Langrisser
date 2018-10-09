using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000651 RID: 1617
	[ProtoContract(Name = "ProFixedStoreItem")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProFixedStoreItem : IExtensible
	{
		// Token: 0x06005849 RID: 22601 RVA: 0x0019AA80 File Offset: 0x00198C80
		public ProFixedStoreItem()
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

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600584A RID: 22602 RVA: 0x0019AAE8 File Offset: 0x00198CE8
		// (set) Token: 0x0600584B RID: 22603 RVA: 0x0019AAF0 File Offset: 0x00198CF0
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x0019AAFC File Offset: 0x00198CFC
		// (set) Token: 0x0600584D RID: 22605 RVA: 0x0019AB04 File Offset: 0x00198D04
		[ProtoMember(2, IsRequired = true, Name = "BoughtCount", DataFormat = DataFormat.TwosComplement)]
		public int BoughtCount
		{
			get
			{
				return this._BoughtCount;
			}
			set
			{
				this._BoughtCount = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0019AB10 File Offset: 0x00198D10
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x0019AB18 File Offset: 0x00198D18
		[ProtoMember(3, IsRequired = true, Name = "IsFirstBuy", DataFormat = DataFormat.Default)]
		public bool IsFirstBuy
		{
			get
			{
				return this._IsFirstBuy;
			}
			set
			{
				this._IsFirstBuy = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0019AB24 File Offset: 0x00198D24
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x0019AB2C File Offset: 0x00198D2C
		[ProtoMember(4, IsRequired = true, Name = "NextFlushTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005852 RID: 22610 RVA: 0x0019AB38 File Offset: 0x00198D38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x0019AB48 File Offset: 0x00198D48
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

		// Token: 0x06005854 RID: 22612 RVA: 0x0019AC14 File Offset: 0x00198E14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProFixedStoreItem));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004246 RID: 16966
		private int _Id;

		// Token: 0x04004247 RID: 16967
		private int _BoughtCount;

		// Token: 0x04004248 RID: 16968
		private bool _IsFirstBuy;

		// Token: 0x04004249 RID: 16969
		private long _NextFlushTime;

		// Token: 0x0400424A RID: 16970
		private IExtension extensionObject;

		// Token: 0x0400424B RID: 16971
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400424C RID: 16972
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400424D RID: 16973
		private LuaFunction m_ctor_hotfix;
	}
}
