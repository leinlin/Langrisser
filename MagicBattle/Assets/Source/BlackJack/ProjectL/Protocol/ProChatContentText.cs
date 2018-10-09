using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062B RID: 1579
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatContentText")]
	[Serializable]
	public class ProChatContentText : IExtensible
	{
		// Token: 0x060056AF RID: 22191 RVA: 0x00195FF8 File Offset: 0x001941F8
		public ProChatContentText()
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

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060056B0 RID: 22192 RVA: 0x0019606C File Offset: 0x0019426C
		// (set) Token: 0x060056B1 RID: 22193 RVA: 0x00196074 File Offset: 0x00194274
		[ProtoMember(1, IsRequired = false, Name = "Text", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x00196080 File Offset: 0x00194280
		// (set) Token: 0x060056B3 RID: 22195 RVA: 0x00196088 File Offset: 0x00194288
		[ProtoMember(2, IsRequired = false, Name = "SystemContentTemplateId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int SystemContentTemplateId
		{
			get
			{
				return this._SystemContentTemplateId;
			}
			set
			{
				this._SystemContentTemplateId = value;
			}
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00196094 File Offset: 0x00194294
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x001960A4 File Offset: 0x001942A4
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

		// Token: 0x060056B6 RID: 22198 RVA: 0x00196170 File Offset: 0x00194370
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatContentText));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004123 RID: 16675
		private string _Text = string.Empty;

		// Token: 0x04004124 RID: 16676
		private int _SystemContentTemplateId;

		// Token: 0x04004125 RID: 16677
		private IExtension extensionObject;

		// Token: 0x04004126 RID: 16678
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004127 RID: 16679
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004128 RID: 16680
		private LuaFunction m_ctor_hotfix;
	}
}
