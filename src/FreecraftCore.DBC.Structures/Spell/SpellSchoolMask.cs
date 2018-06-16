using System;

namespace GladBot
{
	[Flags]
	public enum SpellSchoolMask
	{
		SPELL_SCHOOL_MASK_NONE = 0x00,                       // not exist
		SPELL_SCHOOL_MASK_NORMAL = (1 << SpellSchool.SPELL_SCHOOL_NORMAL), // PHYSICAL (Armor)
		SPELL_SCHOOL_MASK_HOLY = (1 << SpellSchool.SPELL_SCHOOL_HOLY),
		SPELL_SCHOOL_MASK_FIRE = (1 << SpellSchool.SPELL_SCHOOL_FIRE),
		SPELL_SCHOOL_MASK_NATURE = (1 << SpellSchool.SPELL_SCHOOL_NATURE),
		SPELL_SCHOOL_MASK_FROST = (1 << SpellSchool.SPELL_SCHOOL_FROST),
		SPELL_SCHOOL_MASK_SHADOW = (1 << SpellSchool.SPELL_SCHOOL_SHADOW),
		SPELL_SCHOOL_MASK_ARCANE = (1 << SpellSchool.SPELL_SCHOOL_ARCANE),

		// unions

		// 124, not include normal and holy damage
		SPELL_SCHOOL_MASK_SPELL = (SPELL_SCHOOL_MASK_FIRE |
			SPELL_SCHOOL_MASK_NATURE | SPELL_SCHOOL_MASK_FROST |
			SPELL_SCHOOL_MASK_SHADOW | SPELL_SCHOOL_MASK_ARCANE),
		// 126
		SPELL_SCHOOL_MASK_MAGIC = (SPELL_SCHOOL_MASK_HOLY | SPELL_SCHOOL_MASK_SPELL),
		// 127
		SPELL_SCHOOL_MASK_ALL = (SPELL_SCHOOL_MASK_NORMAL | SPELL_SCHOOL_MASK_MAGIC)
	};
}