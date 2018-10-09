using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F2 RID: 1778
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EverydaySignAck")]
	[Serializable]
	public class EverydaySignAck : IExtensible
	{
		// Token: 0x06005EEE RID: 24302 RVA: 0x001AE4AC File Offset: 0x001AC6AC
		public EverydaySignAck()
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

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001AE520 File Offset: 0x001AC720
		// (set) Token: 0x06005EF0 RID: 24304 RVA: 0x001AE528 File Offset: 0x001AC728
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

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001AE534 File Offset: 0x001AC734
		[ProtoMember(2, Name = "changed", DataFormat = DataFormat.Default)]
		public List<ProGoods> Changed
		{
			get
			{
				return this._changed;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x001AE53C File Offset: 0x001AC73C
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x001AE544 File Offset: 0x001AC744
		[ProtoMember(3, IsRequired = true, Name = "SignDays", DataFormat = DataFormat.TwosComplement)]
		public int SignDays
		{
			get
			{
				return this._SignDays;
			}
			set
			{
				this._SignDays = value;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x001AE550 File Offset: 0x001AC750
		// (set) Token: 0x06005EF5 RID: 24309 RVA: 0x001AE558 File Offset: 0x001AC758
		[ProtoMember(4, IsRequired = true, Name = "SignTime", DataFormat = DataFormat.TwosComplement)]
		public long SignTime
		{
			get
			{
				return this._SignTime;
			}
			set
			{
				this._SignTime = value;
			}
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x001AE564 File Offset: 0x001AC764
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x001AE574 File Offset: 0x001AC774
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

		// Token: 0x06005EF8 RID: 24312 RVA: 0x001AE640 File Offset: 0x001AC840
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EverydaySignAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400470A RID: 18186
		private int _Result;

		// Token: 0x0400470B RID: 18187
		private readonly List<ProGoods> _changed = new List<ProGoods>();

		// Token: 0x0400470C RID: 18188
		private int _SignDays;

		// Token: 0x0400470D RID: 18189
		private long _SignTime;

		// Token: 0x0400470E RID: 18190
		private IExtension extensionObject;

		// Token: 0x0400470F RID: 18191
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004710 RID: 18192
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004711 RID: 18193
		private LuaFunction m_ctor_hotfix;
	}
}
