using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AC RID: 1964
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroSkillsSelectAck")]
	[Serializable]
	public class HeroSkillsSelectAck : IExtensible
	{
		// Token: 0x060064D2 RID: 25810 RVA: 0x001C3C14 File Offset: 0x001C1E14
		public HeroSkillsSelectAck()
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

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x001C3C88 File Offset: 0x001C1E88
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x001C3C90 File Offset: 0x001C1E90
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

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x001C3C9C File Offset: 0x001C1E9C
		// (set) Token: 0x060064D6 RID: 25814 RVA: 0x001C3CA4 File Offset: 0x001C1EA4
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

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x001C3CB0 File Offset: 0x001C1EB0
		[ProtoMember(3, Name = "SkillsId", DataFormat = DataFormat.TwosComplement)]
		public List<int> SkillsId
		{
			get
			{
				return this._SkillsId;
			}
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x001C3CB8 File Offset: 0x001C1EB8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x001C3CC8 File Offset: 0x001C1EC8
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

		// Token: 0x060064DA RID: 25818 RVA: 0x001C3D94 File Offset: 0x001C1F94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkillsSelectAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B92 RID: 19346
		private int _Result;

		// Token: 0x04004B93 RID: 19347
		private int _HeroId;

		// Token: 0x04004B94 RID: 19348
		private readonly List<int> _SkillsId = new List<int>();

		// Token: 0x04004B95 RID: 19349
		private IExtension extensionObject;

		// Token: 0x04004B96 RID: 19350
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B97 RID: 19351
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B98 RID: 19352
		private LuaFunction m_ctor_hotfix;
	}
}
