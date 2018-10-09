using System;
using System.Collections.Generic;

// Token: 0x02001092 RID: 4242
internal struct ObjectMetadata
{
	// Token: 0x17003E95 RID: 16021
	// (get) Token: 0x060156E2 RID: 87778 RVA: 0x0056ECA8 File Offset: 0x0056CEA8
	// (set) Token: 0x060156E3 RID: 87779 RVA: 0x0056ECC8 File Offset: 0x0056CEC8
	public Type ElementType
	{
		get
		{
			if (this.element_type == null)
			{
				return typeof(JsonData);
			}
			return this.element_type;
		}
		set
		{
			this.element_type = value;
		}
	}

	// Token: 0x17003E96 RID: 16022
	// (get) Token: 0x060156E4 RID: 87780 RVA: 0x0056ECD4 File Offset: 0x0056CED4
	// (set) Token: 0x060156E5 RID: 87781 RVA: 0x0056ECDC File Offset: 0x0056CEDC
	public bool IsDictionary
	{
		get
		{
			return this.is_dictionary;
		}
		set
		{
			this.is_dictionary = value;
		}
	}

	// Token: 0x17003E97 RID: 16023
	// (get) Token: 0x060156E6 RID: 87782 RVA: 0x0056ECE8 File Offset: 0x0056CEE8
	// (set) Token: 0x060156E7 RID: 87783 RVA: 0x0056ECF0 File Offset: 0x0056CEF0
	public IDictionary<string, PropertyMetadata> Properties
	{
		get
		{
			return this.properties;
		}
		set
		{
			this.properties = value;
		}
	}

	// Token: 0x0400BABC RID: 47804
	private Type element_type;

	// Token: 0x0400BABD RID: 47805
	private bool is_dictionary;

	// Token: 0x0400BABE RID: 47806
	private IDictionary<string, PropertyMetadata> properties;
}
