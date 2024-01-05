#pragma once

#include "IWeapon.h"

namespace DnD {

class NoWeapon :
    public IWeapon
{
public:
    int getDamage() const override;
};

} // namespace DnD