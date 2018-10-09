using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A6 RID: 1958
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroJobTransferAck")]
	[Serializable]
	public class HeroJobTransferAck : IExtensible
	{
		// Token: 0x060064A1 RID: 25761 RVA: 0x001C3108 File Offset: 0x001C1308
		public HeroJobTransferAck()
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

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x060064A2 RID: 25762 RVA: 0x001C3170 File Offset: 0x001C1370
		// (set) Token: 0x060064A3 RID: 25763 RVA: 0x001C3178 File Offset: 0x001C1378
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

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x001C3184 File Offset: 0x001C1384
		// (set) Token: 0x060064A5 RID: 25765 RVA: 0x001C318C File Offset: 0x001C138C
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

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x001C3198 File Offset: 0x001C1398
		// (set) Token: 0x060064A7 RID: 25767 RVA: 0x001C31A0 File Offset: 0x001C13A0
		[ProtoMember(3, IsRequired = true, Name = "jobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._jobRelatedId;
			}
			set
			{
				this._jobRelatedId = value;
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x001C31AC File Offset: 0x001C13AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x001C31BC File Offset: 0x001C13BC
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

		// Token: 0x060064AA RID: 25770 RVA: 0x001C3288 File Offset: 0x001C1488
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B6D RID: 19309
		private int _Result;

		// Token: 0x04004B6E RID: 19310
		private int _HeroId;

		// Token: 0x04004B6F RID: 19311
		private int _jobRelatedId;

		// Token: 0x04004B70 RID: 19312
		private IExtension extensionObject;

		// Token: 0x04004B71 RID: 19313
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B72 RID: 19314
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B73 RID: 19315
		private LuaFunction m_ctor_hotfix;
	}
}
