#pragma once

#include <memory>

#include "ICharacter.h"

namespace DnD {

class Weapon;

class Character
    : public ICharacter
{
public:
    Character();
    virtual ~Character() = default;

private:
    std::unique_ptr<Weapon> m_weapon{};
};

} // namespace DnD