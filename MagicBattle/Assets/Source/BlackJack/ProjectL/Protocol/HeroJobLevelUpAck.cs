using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AA RID: 1962
	[ProtoContract(Name = "HeroJobLevelUpAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroJobLevelUpAck : IExtensible
	{
		// Token: 0x060064C1 RID: 25793 RVA: 0x001C3858 File Offset: 0x001C1A58
		public HeroJobLevelUpAck()
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

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x060064C2 RID: 25794 RVA: 0x001C38C0 File Offset: 0x001C1AC0
		// (set) Token: 0x060064C3 RID: 25795 RVA: 0x001C38C8 File Offset: 0x001C1AC8
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

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x001C38D4 File Offset: 0x001C1AD4
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x001C38DC File Offset: 0x001C1ADC
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

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x060064C6 RID: 25798 RVA: 0x001C38E8 File Offset: 0x001C1AE8
		// (set) Token: 0x060064C7 RID: 25799 RVA: 0x001C38F0 File Offset: 0x001C1AF0
		[ProtoMember(3, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x001C38FC File Offset: 0x001C1AFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x001C390C File Offset: 0x001C1B0C
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

		// Token: 0x060064CA RID: 25802 RVA: 0x001C39D8 File Offset: 0x001C1BD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobLevelUpAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B85 RID: 19333
		private int _Result;

		// Token: 0x04004B86 RID: 19334
		private int _HeroId;

		// Token: 0x04004B87 RID: 19335
		private int _JobRelatedId;

		// Token: 0x04004B88 RID: 19336
		private IExtension extensionObject;

		// Token: 0x04004B89 RID: 19337
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B8A RID: 19338
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B8B RID: 19339
		private LuaFunction m_ctor_hotfix;
	}
}
