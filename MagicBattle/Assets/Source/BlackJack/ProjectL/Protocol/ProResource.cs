using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000693 RID: 1683
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProResource")]
	[Serializable]
	public class ProResource : IExtensible
	{
		// Token: 0x06005B63 RID: 23395 RVA: 0x001A2F4C File Offset: 0x001A114C
		public ProResource()
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

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x001A2FEC File Offset: 0x001A11EC
		[ProtoMember(1, Name = "HeadFrames", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeadFrames
		{
			get
			{
				return this._HeadFrames;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x001A2FF4 File Offset: 0x001A11F4
		[ProtoMember(2, Name = "HeroSkinIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroSkinIds
		{
			get
			{
				return this._HeroSkinIds;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x001A2FFC File Offset: 0x001A11FC
		[ProtoMember(3, Name = "SoldierSkinIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> SoldierSkinIds
		{
			get
			{
				return this._SoldierSkinIds;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06005B67 RID: 23399 RVA: 0x001A3004 File Offset: 0x001A1204
		[ProtoMember(4, Name = "MonthCards", DataFormat = DataFormat.Default)]
		public List<ProMonthCard> MonthCards
		{
			get
			{
				return this._MonthCards;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001A300C File Offset: 0x001A120C
		[ProtoMember(5, Name = "EquipmentIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> EquipmentIds
		{
			get
			{
				return this._EquipmentIds;
			}
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x001A3014 File Offset: 0x001A1214
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x001A3024 File Offset: 0x001A1224
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

		// Token: 0x06005B6B RID: 23403 RVA: 0x001A30F0 File Offset: 0x001A12F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProResource));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400446D RID: 17517
		private readonly List<int> _HeadFrames = new List<int>();

		// Token: 0x0400446E RID: 17518
		private readonly List<int> _HeroSkinIds = new List<int>();

		// Token: 0x0400446F RID: 17519
		private readonly List<int> _SoldierSkinIds = new List<int>();

		// Token: 0x04004470 RID: 17520
		private readonly List<ProMonthCard> _MonthCards = new List<ProMonthCard>();

		// Token: 0x04004471 RID: 17521
		private readonly List<int> _EquipmentIds = new List<int>();

		// Token: 0x04004472 RID: 17522
		private IExtension extensionObject;

		// Token: 0x04004473 RID: 17523
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004474 RID: 17524
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004475 RID: 17525
		private LuaFunction m_ctor_hotfix;
	}
}
