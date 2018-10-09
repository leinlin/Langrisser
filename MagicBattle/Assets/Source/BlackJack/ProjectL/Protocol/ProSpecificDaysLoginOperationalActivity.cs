using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000664 RID: 1636
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProSpecificDaysLoginOperationalActivity")]
	[Serializable]
	public class ProSpecificDaysLoginOperationalActivity : IExtensible
	{
		// Token: 0x06005968 RID: 22888 RVA: 0x0019D36C File Offset: 0x0019B56C
		public ProSpecificDaysLoginOperationalActivity()
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

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x0019D3E8 File Offset: 0x0019B5E8
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x0019D3F0 File Offset: 0x0019B5F0
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x0019D3FC File Offset: 0x0019B5FC
		[ProtoMember(2, Name = "SpecificLoginTimes", DataFormat = DataFormat.TwosComplement)]
		public List<long> SpecificLoginTimes
		{
			get
			{
				return this._SpecificLoginTimes;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x0600596C RID: 22892 RVA: 0x0019D404 File Offset: 0x0019B604
		[ProtoMember(3, Name = "GainRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> GainRewardIndexs
		{
			get
			{
				return this._GainRewardIndexs;
			}
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x0019D40C File Offset: 0x0019B60C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x0019D41C File Offset: 0x0019B61C
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

		// Token: 0x0600596F RID: 22895 RVA: 0x0019D4E8 File Offset: 0x0019B6E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProSpecificDaysLoginOperationalActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004306 RID: 17158
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x04004307 RID: 17159
		private readonly List<long> _SpecificLoginTimes = new List<long>();

		// Token: 0x04004308 RID: 17160
		private readonly List<int> _GainRewardIndexs = new List<int>();

		// Token: 0x04004309 RID: 17161
		private IExtension extensionObject;

		// Token: 0x0400430A RID: 17162
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400430B RID: 17163
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400430C RID: 17164
		private LuaFunction m_ctor_hotfix;
	}
}
