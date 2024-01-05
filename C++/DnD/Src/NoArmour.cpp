#include "NoArmour.h"

namespace DnD {

NoArmour::NoArmour()
{
}

int DnD::NoArmour::modifyAttack(int damage) const
{
    return damage;
}

int NoArmour::getWeight() const
{
    return 0;
}

std::string NoArmour::getName() const
{
    return "NoName";
}
} // namespace DnD