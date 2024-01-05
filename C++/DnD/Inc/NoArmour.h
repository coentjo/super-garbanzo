#pragma once

#include "IArmour.h"
#include "IItem.h"

namespace DnD {

class NoArmour :
    public IArmour,
    private IItem
{
public:
    NoArmour();

    // Inherited via IArmour
    virtual int modifyAttack(int damage) const override;

    // Inherited via IItem
    virtual int getWeight() const override;
    virtual std::string getName() const override;

};

} // namespace DnD