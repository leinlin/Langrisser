using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AB RID: 1963
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroSkillsSelectReq")]
	[Serializable]
	public class HeroSkillsSelectReq : IExtensible
	{
		// Token: 0x060064CB RID: 25803 RVA: 0x001C3A40 File Offset: 0x001C1C40
		public HeroSkillsSelectReq()
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

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x001C3AB4 File Offset: 0x001C1CB4
		// (set) Token: 0x060064CD RID: 25805 RVA: 0x001C3ABC File Offset: 0x001C1CBC
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x001C3AC8 File Offset: 0x001C1CC8
		[ProtoMember(2, Name = "SkillsId", DataFormat = DataFormat.TwosComplement)]
		public List<int> SkillsId
		{
			get
			{
				return this._SkillsId;
			}
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x001C3AD0 File Offset: 0x001C1CD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x001C3AE0 File Offset: 0x001C1CE0
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

		// Token: 0x060064D1 RID: 25809 RVA: 0x001C3BAC File Offset: 0x001C1DAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkillsSelectReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B8C RID: 19340
		private int _HeroId;

		// Token: 0x04004B8D RID: 19341
		private readonly List<int> _SkillsId = new List<int>();

		// Token: 0x04004B8E RID: 19342
		private IExtension extensionObject;

		// Token: 0x04004B8F RID: 19343
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B90 RID: 19344
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B91 RID: 19345
		private LuaFunction m_ctor_hotfix;
	}
}
