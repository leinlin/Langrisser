using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000654 RID: 1620
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRafflePool")]
	[Serializable]
	public class ProRafflePool : IExtensible
	{
		// Token: 0x0600586C RID: 22636 RVA: 0x0019B074 File Offset: 0x00199274
		public ProRafflePool()
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

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x0600586D RID: 22637 RVA: 0x0019B0E8 File Offset: 0x001992E8
		// (set) Token: 0x0600586E RID: 22638 RVA: 0x0019B0F0 File Offset: 0x001992F0
		[ProtoMember(1, IsRequired = true, Name = "RafflePoolId", DataFormat = DataFormat.TwosComplement)]
		public int RafflePoolId
		{
			get
			{
				return this._RafflePoolId;
			}
			set
			{
				this._RafflePoolId = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600586F RID: 22639 RVA: 0x0019B0FC File Offset: 0x001992FC
		// (set) Token: 0x06005870 RID: 22640 RVA: 0x0019B104 File Offset: 0x00199304
		[ProtoMember(2, IsRequired = true, Name = "DrawedCount", DataFormat = DataFormat.TwosComplement)]
		public int DrawedCount
		{
			get
			{
				return this._DrawedCount;
			}
			set
			{
				this._DrawedCount = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06005871 RID: 22641 RVA: 0x0019B110 File Offset: 0x00199310
		[ProtoMember(3, Name = "DrawedItemIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> DrawedItemIds
		{
			get
			{
				return this._DrawedItemIds;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x0019B118 File Offset: 0x00199318
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x0019B120 File Offset: 0x00199320
		[ProtoMember(4, IsRequired = true, Name = "FreeDrawedCount", DataFormat = DataFormat.TwosComplement)]
		public int FreeDrawedCount
		{
			get
			{
				return this._FreeDrawedCount;
			}
			set
			{
				this._FreeDrawedCount = value;
			}
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0019B12C File Offset: 0x0019932C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0019B13C File Offset: 0x0019933C
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

		// Token: 0x06005876 RID: 22646 RVA: 0x0019B208 File Offset: 0x00199408
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRafflePool));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400425E RID: 16990
		private int _RafflePoolId;

		// Token: 0x0400425F RID: 16991
		private int _DrawedCount;

		// Token: 0x04004260 RID: 16992
		private readonly List<int> _DrawedItemIds = new List<int>();

		// Token: 0x04004261 RID: 16993
		private int _FreeDrawedCount;

		// Token: 0x04004262 RID: 16994
		private IExtension extensionObject;

		// Token: 0x04004263 RID: 16995
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004264 RID: 16996
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004265 RID: 16997
		private LuaFunction m_ctor_hotfix;
	}
}
