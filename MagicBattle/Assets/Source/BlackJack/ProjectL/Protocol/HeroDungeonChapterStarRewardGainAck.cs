using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A0 RID: 1952
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroDungeonChapterStarRewardGainAck")]
	[Serializable]
	public class HeroDungeonChapterStarRewardGainAck : IExtensible
	{
		// Token: 0x06006465 RID: 25701 RVA: 0x001C2574 File Offset: 0x001C0774
		public HeroDungeonChapterStarRewardGainAck()
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

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x001C25E8 File Offset: 0x001C07E8
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x001C25F0 File Offset: 0x001C07F0
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

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x001C25FC File Offset: 0x001C07FC
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x001C2604 File Offset: 0x001C0804
		[ProtoMember(2, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get
			{
				return this._ChapterId;
			}
			set
			{
				this._ChapterId = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x001C2610 File Offset: 0x001C0810
		// (set) Token: 0x0600646B RID: 25707 RVA: 0x001C2618 File Offset: 0x001C0818
		[ProtoMember(3, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				this._Index = value;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x001C2624 File Offset: 0x001C0824
		// (set) Token: 0x0600646D RID: 25709 RVA: 0x001C262C File Offset: 0x001C082C
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x001C2638 File Offset: 0x001C0838
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x001C2640 File Offset: 0x001C0840
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x001C2650 File Offset: 0x001C0850
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

		// Token: 0x06006471 RID: 25713 RVA: 0x001C271C File Offset: 0x001C091C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonChapterStarRewardGainAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B41 RID: 19265
		private int _Result;

		// Token: 0x04004B42 RID: 19266
		private int _ChapterId;

		// Token: 0x04004B43 RID: 19267
		private int _Index;

		// Token: 0x04004B44 RID: 19268
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004B45 RID: 19269
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004B46 RID: 19270
		private IExtension extensionObject;

		// Token: 0x04004B47 RID: 19271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B48 RID: 19272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B49 RID: 19273
		private LuaFunction m_ctor_hotfix;
	}
}
