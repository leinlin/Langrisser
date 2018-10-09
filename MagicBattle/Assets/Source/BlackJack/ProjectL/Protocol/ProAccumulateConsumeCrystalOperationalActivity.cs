using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069E RID: 1694
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProAccumulateConsumeCrystalOperationalActivity")]
	[Serializable]
	public class ProAccumulateConsumeCrystalOperationalActivity : IExtensible
	{
		// Token: 0x06005BEE RID: 23534 RVA: 0x001A45D8 File Offset: 0x001A27D8
		public ProAccumulateConsumeCrystalOperationalActivity()
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

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06005BEF RID: 23535 RVA: 0x001A464C File Offset: 0x001A284C
		// (set) Token: 0x06005BF0 RID: 23536 RVA: 0x001A4654 File Offset: 0x001A2854
		[ProtoMember(1, IsRequired = true, Name = "BasicInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo BasicInfo
		{
			get
			{
				return this._BasicInfo;
			}
			set
			{
				this._BasicInfo = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x001A4660 File Offset: 0x001A2860
		// (set) Token: 0x06005BF2 RID: 23538 RVA: 0x001A4668 File Offset: 0x001A2868
		[ProtoMember(2, IsRequired = true, Name = "AccumulateConsumeCrystal", DataFormat = DataFormat.TwosComplement)]
		public int AccumulateConsumeCrystal
		{
			get
			{
				return this._AccumulateConsumeCrystal;
			}
			set
			{
				this._AccumulateConsumeCrystal = value;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06005BF3 RID: 23539 RVA: 0x001A4674 File Offset: 0x001A2874
		[ProtoMember(3, Name = "GainRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> GainRewardIndexs
		{
			get
			{
				return this._GainRewardIndexs;
			}
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x001A467C File Offset: 0x001A287C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x001A468C File Offset: 0x001A288C
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

		// Token: 0x06005BF6 RID: 23542 RVA: 0x001A4758 File Offset: 0x001A2958
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProAccumulateConsumeCrystalOperationalActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044CF RID: 17615
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x040044D0 RID: 17616
		private int _AccumulateConsumeCrystal;

		// Token: 0x040044D1 RID: 17617
		private readonly List<int> _GainRewardIndexs = new List<int>();

		// Token: 0x040044D2 RID: 17618
		private IExtension extensionObject;

		// Token: 0x040044D3 RID: 17619
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044D4 RID: 17620
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044D5 RID: 17621
		private LuaFunction m_ctor_hotfix;
	}
}
