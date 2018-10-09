using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000729 RID: 1833
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSSurveyNtf")]
	[Serializable]
	public class DSSurveyNtf : IExtensible
	{
		// Token: 0x060060BD RID: 24765 RVA: 0x001B4B3C File Offset: 0x001B2D3C
		public DSSurveyNtf()
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

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x060060BE RID: 24766 RVA: 0x001B4BA4 File Offset: 0x001B2DA4
		// (set) Token: 0x060060BF RID: 24767 RVA: 0x001B4BAC File Offset: 0x001B2DAC
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x060060C0 RID: 24768 RVA: 0x001B4BB8 File Offset: 0x001B2DB8
		// (set) Token: 0x060060C1 RID: 24769 RVA: 0x001B4BC0 File Offset: 0x001B2DC0
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Survey", DataFormat = DataFormat.Default)]
		public ProSurvey Survey
		{
			get
			{
				return this._Survey;
			}
			set
			{
				this._Survey = value;
			}
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x001B4BCC File Offset: 0x001B2DCC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x001B4BDC File Offset: 0x001B2DDC
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

		// Token: 0x060060C4 RID: 24772 RVA: 0x001B4CA8 File Offset: 0x001B2EA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSSurveyNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400486F RID: 18543
		private uint _Version;

		// Token: 0x04004870 RID: 18544
		private ProSurvey _Survey;

		// Token: 0x04004871 RID: 18545
		private IExtension extensionObject;

		// Token: 0x04004872 RID: 18546
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004873 RID: 18547
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004874 RID: 18548
		private LuaFunction m_ctor_hotfix;
	}
}
