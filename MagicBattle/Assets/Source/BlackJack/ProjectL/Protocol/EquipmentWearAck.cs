using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B8 RID: 1976
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentWearAck")]
	[Serializable]
	public class EquipmentWearAck : IExtensible
	{
		// Token: 0x0600653F RID: 25919 RVA: 0x001C5290 File Offset: 0x001C3490
		public EquipmentWearAck()
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

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x001C52F8 File Offset: 0x001C34F8
		// (set) Token: 0x06006541 RID: 25921 RVA: 0x001C5300 File Offset: 0x001C3500
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

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x001C530C File Offset: 0x001C350C
		// (set) Token: 0x06006543 RID: 25923 RVA: 0x001C5314 File Offset: 0x001C3514
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

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x001C5320 File Offset: 0x001C3520
		// (set) Token: 0x06006545 RID: 25925 RVA: 0x001C5328 File Offset: 0x001C3528
		[ProtoMember(3, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x001C5334 File Offset: 0x001C3534
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x001C5344 File Offset: 0x001C3544
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

		// Token: 0x06006548 RID: 25928 RVA: 0x001C5410 File Offset: 0x001C3610
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentWearAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BE1 RID: 19425
		private int _Result;

		// Token: 0x04004BE2 RID: 19426
		private int _HeroId;

		// Token: 0x04004BE3 RID: 19427
		private ulong _InstanceId;

		// Token: 0x04004BE4 RID: 19428
		private IExtension extensionObject;

		// Token: 0x04004BE5 RID: 19429
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BE6 RID: 19430
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BE7 RID: 19431
		private LuaFunction m_ctor_hotfix;
	}
}
