using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000665 RID: 1637
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProAccumulateLoginOperationalActivity")]
	[Serializable]
	public class ProAccumulateLoginOperationalActivity : IExtensible
	{
		// Token: 0x06005970 RID: 22896 RVA: 0x0019D550 File Offset: 0x0019B750
		public ProAccumulateLoginOperationalActivity()
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06005971 RID: 22897 RVA: 0x0019D5CC File Offset: 0x0019B7CC
		// (set) Token: 0x06005972 RID: 22898 RVA: 0x0019D5D4 File Offset: 0x0019B7D4
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

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06005973 RID: 22899 RVA: 0x0019D5E0 File Offset: 0x0019B7E0
		[ProtoMember(2, Name = "SpecificLoginTimes", DataFormat = DataFormat.TwosComplement)]
		public List<long> SpecificLoginTimes
		{
			get
			{
				return this._SpecificLoginTimes;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x0019D5E8 File Offset: 0x0019B7E8
		[ProtoMember(3, Name = "GainRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> GainRewardIndexs
		{
			get
			{
				return this._GainRewardIndexs;
			}
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x0019D5F0 File Offset: 0x0019B7F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x0019D600 File Offset: 0x0019B800
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

		// Token: 0x06005977 RID: 22903 RVA: 0x0019D6CC File Offset: 0x0019B8CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProAccumulateLoginOperationalActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400430D RID: 17165
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x0400430E RID: 17166
		private readonly List<long> _SpecificLoginTimes = new List<long>();

		// Token: 0x0400430F RID: 17167
		private readonly List<int> _GainRewardIndexs = new List<int>();

		// Token: 0x04004310 RID: 17168
		private IExtension extensionObject;

		// Token: 0x04004311 RID: 17169
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004312 RID: 17170
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004313 RID: 17171
		private LuaFunction m_ctor_hotfix;
	}
}
