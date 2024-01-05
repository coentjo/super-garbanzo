#pragma once

#include "Item.h"

namespace DnD {

class IWeapon
{
public:
    virtual ~IWeapon() {}

    virtual int getDamage() const = 0;
};

} // namespace DnD